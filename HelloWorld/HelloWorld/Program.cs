using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {

                var request = (HttpWebRequest)WebRequest.Create("https://api.twitch.tv/kraken/streams/shaboozey");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                MessageBox.Show("get response");
                var response = (HttpWebResponse)request.GetResponse();
                MessageBox.Show(response.ToString());

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                MessageBox.Show(responseString);

            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message + "\r\n");
                foreach (String Key in e.Response.Headers.AllKeys)
                {
                    MessageBox.Show(Key + " - " + e.Response.Headers[Key] + "\r\n");
                }

            }*/

            string[] channels = new string[2] {"Shaboozey","totalbiscuit"};
            foreach (string naam in channels)
            {
                var request = (HttpWebRequest)WebRequest.Create("https://api.twitch.tv/kraken/streams/" + naam);
                var response = request.GetResponse();
                MessageBox.Show(response.ToString());

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                string cutstring = responseString.

                MessageBox.Show(responseString);
            
            }
            /*$dataArray = json_decode(@file_get_contents('https://api.twitch.tv/kraken/streams?channel=' . $callAPI), true);

            foreach($dataArray['streams'] as $mydata){
            if($mydata['_id'] != null){
	            $name 		= $mydata['channel']['display_name'];
	            $game		= $mydata['channel']['game'];
	            $url		= $mydata['channel']['url'];		

        	MessageBox.Show("<a href=\"$url\">" + name +" "+  game + "</a>");*/

       }
    }
}
