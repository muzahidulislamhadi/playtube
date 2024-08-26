//###############################################################
// Author >> Elin Doughouz
// Copyright (c) PlayTube 12/07/2018 All Right Reserved
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// Follow me on facebook >> https://www.facebook.com/Elindoughous
// Doc https://doughouzlight.com/?onepage-docs=playtube-andorid
//=========================================================

using PlayTube.Helpers.Models;
using System.Collections.Generic;

namespace PlayTube
{
    internal static class AppSettings
    {
        /// <summary>
        /// Deep Links To App Content
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">demo.playtubescript.com</string>
        /// </summary>
        public static readonly string TripleDesAppServiceProvider = "mTIo+ZfgSQFKe1KGn3GJAhA21durKCjW/yNqMfQSl3w/rTt+G0+n7PB1+mm9zm6raTC0iMjwN+tOijhOh25xygJmjiCWBXKVf8cL3p8YcRBk64/pmDSEo0EqYCwKHbJOr9eprPFyFOK3oLmEn/HUo0sO93E9G5ar6N25W2Fa65eiHjG4BAbzQU9fvNJXFWPtCrPBopcVIElCqqlRBIcbvv5SBOiGDIBQh2DzUSiTqUYakfqAplYoBwHHOCPOHLMi4OqjwMT1N58FywsmYBoBpu3Q/7gdBz6MY8tuDSWnlYEi8ar1Fh0vn+HvwfQzUrH8MloLrcdklFph0AQxxyIDWAlNAp1w3dwyCprfhZGvJMtEiyNCq+XDz/bHvDp1koeM40N1Rz2SeVTY/oEvISVwlaSFw8v7Sla7WYbpvsZ1lyXh49eeI1vYSQ1ctjaUSOFMJdipJ3FT6M6DTi8pycwXHP47VvcdHM0iOSP+guelWSq7Gdz0VTRKgeQ/SpwuPYc+UXFYD0B2emQNxcygp/wWSF5sBbp9QNLnOUrcmoexqkDN3b62020QZhHg0l79d031RvGicli+vOF7mphuOdRsQkQDhuU654qjqcS2mdea1PLoqQfS5ATBfiHZ8jFf9eeLoFWi2RLBOjiO4TRhXS+ZhzZ+/0ooI2EgeZkcXC8xIIDf0JhAq9lBDNTxAZqtA0bJco2KTcEqAb7gas1FAz2h4Mq3NSLm85PNYPRNuNoMFgXcNXP/pyR/YY4My2vvmH2ajDl9aEQO5ztcSYg4BRTtHTqRA34d8BOopAsx5hFlFuhgCdcYG+TIhEeGqG51bD15ygg9M+myxAaeMweEvPiWamG9wXMU028MfEOK3CUy1kiOwqi2oVdr4cKaa374ZL+na2lw6Kxqtz5YT5iFx1QTt9vVjZxXZCW0vpngX7Cr3Ue71clDz1ke/Qq6FbnUiLVFxMDqIZ3RaPz7A7fRtTfCam1bYPmukxtL5d7BgDo5xdLES0JvU8Qwih9mtkxaKZVtzQ36Lfq272K7BeF3kUm339K2/4RzVE98nccs539A+HJF2Z4nuOUwjQV2YObZLQFH80enie0yF447vtXb5jLFbYimPpmdFHaOTXtS0AHiv5cUs9h2sKLGSVxDbhthJrgQbWUL5Y+a6wpQZAaW8pjx8hkXnpjWVGsLLuJEprH5NuQZm8Vw1gxhP57y2AYUxyQnatAi9R7dRK8+XgconJgBcHBcYp1PtYIXzhYvM/dzeagWmfOdialAJpBlLfNp2B1QE6D5DwLtzl1psUS9yeNSSfomeCSPX5U0wfbOPrfZfrhfNQhK/1XheNxG7AT+Uxlj35LgUgP4mzK2v7Q2Nt+2joETF54g4sPIEndtmeYIBETaMYSKQ4MLO80nv8F8NSwdQyNpYbnP/1Y1g6C5oDd758wxSx+OCnrBzlAxMivnYsGGZEpu/w3/C2BHITYkrX80oMuwZap/mJNdMyyz8pjXbdCj51jXZGAVmlIsf7OOmQ0IOjITPQUOEJ+zP/9uTSHpLvoISE3Kf3QiRmSa5jyUtnbHG3zdkQS9B121LRZ07MQXaRZMTAj6Rvn+7gLVveX0NMv/WnFoeReoRnJPlNHN2U3deMvtPqfHukPjytZtAzNlD/PbGPHBzGp0U1zrDXfF9/s9nGwpW5e+mmarxmqzpwPg5h6CtZ3On2mPDdikK5k373vYbsBzPgJFZikdvRTW66a/7sCVEA9iLRSlhKJhmXU0reo7w8Hq9hfeZy8/8P+vUJz4ZZPqo3uggIsLpmJI4sxarx7Q60tSGig7w0O0LcZzihqnZc9yMWOw5NbGNnfAeYBGlG8O+t3zRgUD5NJDN6mAk+y9Rp0fjEcVqtEX03LBwHoEmT2QkBAZX7nyWoc=";

        //Main Settings >>>>> 
        //********************************************************* 
        public static readonly string ApplicationName = "PlayTube";
        public static readonly string DatabaseName = "PlayTubeVideos";
        public static string Version = "3.8";

        //Main Colors >>
        //*********************************************************
        public static readonly string MainColor = "#0F64F7";

        public static readonly PlayerTheme PlayerTheme = PlayerTheme.Theme2;

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar

        //Set Language User on site from phone 
        public static readonly bool SetLangUser = false;

        public static readonly Dictionary<string, string> LanguageList = new Dictionary<string, string>() //New
        {
            {"en", "English"},
            {"ar", "Arabic"},
        };

        //Error Report Mode
        //*********************************************************
        public static readonly bool SetApisReportMode = true;

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "e06a3585-d0ac-44ef-b2df-0c24abc23682";

        //Tv Settings >>
        //*********************************************************
        public static readonly bool LinkWithTv = true;

        //AdMob >> Please add the code ads in the Here and analytic.xml 
        //*********************************************************
        public static readonly ShowAds ShowAds = ShowAds.AllUsers;

        public static readonly bool RewardedAdvertisingSystem = true; //New

        //Three times after entering the ad is displayed
        public static readonly int ShowAdInterstitialCount = 3;
        public static readonly int ShowAdRewardedVideoCount = 3;
        public static readonly int ShowAdNativeCount = 4;
        public static readonly int ShowAdAppOpenCount = 2;

        public static readonly bool ShowAdMobBanner = true;
        public static readonly bool ShowAdMobInterstitial = true;
        public static readonly bool ShowAdMobRewardVideo = true;
        public static readonly bool ShowAdMobNative = true;
        public static readonly bool ShowAdMobAppOpen = true;
        public static readonly bool ShowAdMobRewardedInterstitial = true;

        public static readonly string AdInterstitialKey = "ca-app-pub-5135691635931982/6168068662";
        public static readonly string AdRewardVideoKey = "ca-app-pub-5135691635931982/4663415300";
        public static readonly string AdAdMobNativeKey = "ca-app-pub-5135691635931982/2619721801";
        public static readonly string AdAdMobAppOpenKey = "ca-app-pub-5135691635931982/4967593321";
        public static readonly string AdRewardedInterstitialKey = "ca-app-pub-5135691635931982/1850136085";

        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static readonly bool ShowFbBannerAds = false;
        public static readonly bool ShowFbInterstitialAds = false;
        public static readonly bool ShowFbRewardVideoAds = false;
        public static readonly bool ShowFbNativeAds = false;

        //YOUR_PLACEMENT_ID
        public static readonly string AdsFbBannerKey = "250485588986218_554026418632132";
        public static readonly string AdsFbInterstitialKey = "250485588986218_554026125298828";
        public static readonly string AdsFbRewardVideoKey = "250485588986218_554072818627492";
        public static readonly string AdsFbNativeKey = "250485588986218_554706301897477";

        //Ads AppLovin >> Please add the code ad in the Here 
        //*********************************************************  
        public static readonly bool ShowAppLovinBannerAds = false;
        public static readonly bool ShowAppLovinInterstitialAds = false;
        public static readonly bool ShowAppLovinRewardAds = false;

        public static readonly string AdsAppLovinBannerId = "f9ebf067458aa1df";
        public static readonly string AdsAppLovinInterstitialId = "bd6fa0d996c6fceb";
        public static readonly string AdsAppLovinRewardedId = "d3269ba46c446f63";
        //********************************************************* 

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file or AndroidManifest.xml
        //Facebook >> ../values/analytic.xml  
        //Google >> ../Properties/AndroidManifest.xml .. line 27
        //*********************************************************
        public static readonly bool EnableSmartLockForPasswords = false;

        public static readonly bool ShowFacebookLogin = true;
        public static readonly bool ShowGoogleLogin = true;
        public static readonly bool ShowWoWonderLogin = true;

        public static readonly string AppNameWoWonder = "WoWonder";
        public static readonly string WoWonderDomainUri = "https://demo.wowonder.com";
        public static readonly string WoWonderAppKey = "35bf23159ca898e246e5e84069f4deba1b81ee97-60b93b3942f269c7a29a1760199642ec-46595136";

        public static readonly string ClientId = "404363570731-j48d139m31tgaq2tj0gamg8ah430botj.apps.googleusercontent.com";

        //First Page
        //*********************************************************
        public static readonly bool ShowSkipButton = true;

        public static readonly bool ShowRegisterButton = true;
        public static readonly bool EnablePhoneNumber = false;

        //Set Theme Full Screen App
        //*********************************************************
        public static readonly bool EnableFullScreenApp = false;
        public static bool EnablePictureToPictureMode = true; //>> Not Working >> Next update 

        //Data Channal Users >> About
        //*********************************************************
        public static readonly bool ShowEmailAccount = true;
        public static readonly bool ShowActivities = true;

        //Tab >> 
        //*********************************************************
        public static readonly bool ShowArticle = true;
        public static readonly bool ShowMovies = true;
        public static readonly bool ShowShorts = true;
        public static readonly bool ShowChannelPopular = true;

        //how in search 
        public static readonly List<string> LastKeyWordList = new List<string>() { "Music", "Party", "Nature", "Snow", "Entertainment", "Holidays", "Comedy", "Politics", "Suspense" };

        //Offline Watched Videos >>  
        //*********************************************************
        public static readonly bool AllowOfflineDownload = true;
        public static readonly bool AllowDownloadProUser = true;
        public static readonly bool AllowWatchLater = true;
        public static readonly bool AllowRecentlyWatched = true;
        public static readonly bool AllowPlayLists = true;
        public static readonly bool AllowLiked = true;
        public static readonly bool AllowShared = true;
        public static readonly bool AllowPaid = true;

        //Import && Upload Videos >>  
        //*********************************************************
        public static bool ShowButtonImport { get; set; } = true;
        public static bool ShowButtonUpload { get; set; } = true;

        //Last_Messages Page >>
        ///********************************************************* 
        public static readonly bool RunSoundControl = true;
        public static readonly int RefreshChatActivitiesSeconds = 6000; // 6 Seconds
        public static readonly int MessageRequestSpeed = 3000; // 3 Seconds

        public static readonly int ShowButtonSkip = 10; // 6 Seconds 

        //Set Theme App >> Color - Tab
        //*********************************************************
        public static TabTheme SetTabDarkTheme = TabTheme.Light;

        public static readonly bool SetYoutubeTypeBadgeIcon = true;
        public static readonly bool SetVimeoTypeBadgeIcon = true;
        public static readonly bool SetDailyMotionTypeBadgeIcon = true;
        public static readonly bool SetTwichTypeBadgeIcon = true;
        public static readonly bool SetOkTypeBadgeIcon = true;
        public static readonly bool SetFacebookTypeBadgeIcon = true;

        //Bypass Web Errors 
        ///*********************************************************
        public static readonly bool TurnTrustFailureOnWebException = true;
        public static readonly bool TurnSecurityProtocolType3072On = true;


        public static readonly int AvatarSize = 60;
        public static readonly int ImageSize = 400;

        //Home Page 
        //*********************************************************
        public static readonly bool ShowStockVideo = true;

        public static readonly int CountVideosTop = 10;
        public static readonly int CountVideosLatest = 10;
        public static readonly int CountVideosFav = 10;
        public static readonly int CountVideosLive = 13;
        public static readonly int CountVideosStock = 10;

        /// <summary>
        /// if Radius you can select how much Radius in the parameter #CardPlayerViewRadius
        /// </summary>
        public static readonly CardPlayerView CardPlayerView = CardPlayerView.Square;
        public static readonly float CardPlayerViewRadius = 10F;

        public static readonly bool ShowGoLive = true;
        public static readonly string AppIdAgoraLive = "9471c47b589c4a35abf3f7338ef18629";

        public static readonly ShareSystem ShareSystem = ShareSystem.WebsiteUrl;

        //Settings 
        //*********************************************************
        public static readonly bool ShowEditPassword = true;
        public static readonly bool ShowMonetization = true; //(Withdrawals)
        public static readonly bool ShowVerification = true;
        public static readonly bool ShowBlockedUsers = true;
        public static readonly bool ShowPoints = true;
        public static readonly bool ShowSettingsTwoFactor = true;
        public static readonly bool ShowSettingsManageSessions = true;

        public static readonly bool ShowSettingsRateApp = true;
        public static readonly int ShowRateAppCount = 5;

        public static readonly bool ShowSettingsUpdateManagerApp = false;

        public static readonly bool ShowGoPro = true;
        public static readonly double AmountGoPro = 10; //new 

        public static readonly bool ShowClearHistory = true;
        public static readonly bool ShowClearCache = true;

        public static readonly bool ShowHelp = true;
        public static readonly bool ShowTermsOfUse = true;
        public static readonly bool ShowAbout = true;
        public static readonly bool ShowDeleteAccount = true;

        //*********************************************************
        /// <summary>
        /// Currency
        /// CurrencyStatic = true : get currency from app not api 
        /// CurrencyStatic = false : get currency from api (default)
        /// </summary>
        public static readonly bool CurrencyStatic = false;
        public static readonly string CurrencyIconStatic = "$";
        public static readonly string CurrencyCodeStatic = "USD";


        //********************************************************* 
        public static readonly bool RentVideosSystem = true;

        //*********************************************************  
        public static readonly bool DonateVideosSystem = true;

        //*********************************************************  
        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// 
        /// Add info keys in Payment Methods : https://prnt.sc/1z5bffc https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        ///
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static readonly bool ShowPaypal = true;
        public static readonly string MerchantAccountId = "tester";

        public static readonly string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4ccmn4t7*******";
        public static readonly string ProductionTokenizationKey = "production_t2wns2y2_dfy45******";

        public static readonly bool ShowCreditCard = true;
        public static readonly bool ShowBankTransfer = true;

        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="com.android.vending.BILLING" />
        /// </summary>
        public static readonly bool ShowInAppBilling = true;

        //*********************************************************   
        public static readonly bool ShowCashFree = true;

        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static readonly string CashFreeCurrency = "INR";

        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static readonly string RazorPayCurrency = "INR";

        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 18 
        /// </summary>
        public static readonly bool ShowRazorPay = true;

        public static readonly bool ShowPayStack = true;
        public static readonly bool ShowPaySera = true;
        public static readonly bool ShowSecurionPay = true;
        public static readonly bool ShowAuthorizeNet = true;
        public static readonly bool ShowIyziPay = true;
        public static readonly bool ShowAamarPay = true;

        /// <summary>
        /// FlutterWave get Api Keys From https://app.flutterwave.com/dashboard/settings/apis/live
        /// </summary>
        public static readonly bool ShowFlutterWave = true;
        public static readonly string FlutterWaveCurrency = "NGN";
        public static readonly string FlutterWavePublicKey = "FLWPUBK_TEST-9c877b3110438191127e631c89***";
        public static readonly string FlutterWaveEncryptionKey = "FLWSECK_TEST298f1f905***";

        //*********************************************************  

        public static readonly bool ShowVideoWithDynamicHeight = true;

        //********************************************************* 
        public static readonly bool ShowTextWithSpace = true;

    }
}