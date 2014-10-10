using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace MineLauncher.Launcher
{

    public class MinecraftSession
    {

        private string _Session = "";
        public string Session { get { return _Session; } }

        private string _ClientToken = "";
        public string ClientToken { get { return _ClientToken; } }

        private string _PlayerName = "";
        public string PlayerName { get { return _PlayerName; } }
        
        private string _ProfileID = "";
        public string ProfileID { get { return _ProfileID; } }
        
        private bool _LoggedIn = false;
        public bool LoggedIn { get { return _LoggedIn; } }

        public string OfflineModePlayerName { get; set; }

        public MinecraftSession()
        {
            this._LoggedIn = false;
        }

        public MinecraftSession(string username, string password)
        {
            GetSession(username, password);
        }

        public MinecraftSession(object session, object clienttoken, object playername, object profileid)
        {
            this._Session = session.ToString();
            this._ClientToken = clienttoken.ToString();
            this._PlayerName = playername.ToString();
            this._ProfileID = profileid.ToString();
            this._LoggedIn = true;
        }

        private void GetSession(string user, string pass)
        {
            try
            {
                string response = "";
                string status = "";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://authserver.mojang.com/authenticate");
                request.UserAgent = "MineLauncher v" + Application.ProductVersion;
                request.Method = "POST";
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    agent = new
                    {
                        name = "Minecraft",
                        version = 1
                    },
                    username = user,
                    password = pass
                });
                byte[] uploadBytes = Encoding.UTF8.GetBytes(json);
                request.ContentType = "application/json";
                request.ContentLength = uploadBytes.Length;
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(uploadBytes, 0, uploadBytes.Length);
                }
                try
                {
                    using (WebResponse webresponse = request.GetResponse())
                    {
                        using (Stream dataStream = webresponse.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(dataStream))
                            {
                                response = reader.ReadToEnd();
                            }
                        }
                    }
                    dynamic responseJson = JsonConvert.DeserializeObject(response);
                    if (responseJson.accessToken != null)
                    {
                        _Session = responseJson.accessToken;
                        _ClientToken = responseJson.clientToken;
                        if (responseJson.selectedProfile.id != null)
                        {
                            _ProfileID = responseJson.selectedProfile.id;
                            _PlayerName = responseJson.selectedProfile.name;
                            _LoggedIn = true;

                            Dictionary<string, object> logininfos = new Dictionary<string, object>();
                            logininfos.Add("accessToken", responseJson.accessToken);
                            logininfos.Add("clientToken", responseJson.clientToken);

                            string _json = Newtonsoft.Json.JsonConvert.SerializeObject(logininfos);
                            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\session.json", _json);
                        }
                        else
                        {
                            status = "Error: Missing UUID and Username";
                        }
                    }
                    else if (responseJson.errorMessage != null)
                    {
                        status = "Error: " + responseJson.errorMessage;
                    }
                    else
                    {
                        status = "Error: Had an error and the payload was empty.";
                    }
                    if (status != "")
                    {
                        MessageBox.Show(status, "Error while logging in");
                    }
                }
                catch (System.Net.WebException ex)
                {
                    if (ex.Message.Contains("403")) _LoggedIn = false;
                }
            }
            catch (System.Net.WebException)
            {
                this._LoggedIn = false;
            }
            catch (Exception ex)
            {
                Program.ExceptionTracker.Track(ex, false, false);
                this._LoggedIn = false;
            }
        }

        public static MinecraftSession LoginWithSavedSession()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\session.json"))
            {
                try
                {
                    string response = "";

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://authserver.mojang.com/refresh");
                    request.UserAgent = "MineLauncher v" + Application.ProductVersion;
                    request.Method = "POST";
                    string json = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\session.json");

                    byte[] uploadBytes = Encoding.UTF8.GetBytes(json);
                    request.ContentType = "application/json";
                    request.ContentLength = uploadBytes.Length;
                    using (Stream dataStream = request.GetRequestStream())
                    {
                        dataStream.Write(uploadBytes, 0, uploadBytes.Length);
                    }
                    try
                    {
                        using (WebResponse webresponse = request.GetResponse())
                        {
                            using (Stream dataStream = webresponse.GetResponseStream())
                            {
                                using (StreamReader reader = new StreamReader(dataStream))
                                {
                                    response = reader.ReadToEnd();
                                }
                            }
                        }
                        dynamic responseJson = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                        if (responseJson.accessToken != null)
                        {
                            if (responseJson.selectedProfile.id != null)
                            {
                                Dictionary<string, object> logininfos = new Dictionary<string, object>();
                                logininfos.Add("accessToken", responseJson.accessToken);
                                logininfos.Add("clientToken", responseJson.clientToken);

                                string _json = Newtonsoft.Json.JsonConvert.SerializeObject(logininfos);
                                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\session.json", _json);

                                return new MinecraftSession(responseJson.accessToken, responseJson.clientToken, responseJson.selectedProfile.name, responseJson.selectedProfile.id);
                            }
                            else
                            {
                                return new MinecraftSession();
                            }
                        }
                        else
                        {
                            return new MinecraftSession();
                        }
                    }
                    catch (System.Net.WebException)
                    {
                        return new MinecraftSession();
                    }
                }
                catch (System.Net.WebException)
                {
                    return new MinecraftSession();
                }
                catch (Exception ex)
                {
                    Program.ExceptionTracker.Track(ex, false, false);
                    return new MinecraftSession();
                }
            }
            else
            {
                return new MinecraftSession();
            }
        }

    }

}
