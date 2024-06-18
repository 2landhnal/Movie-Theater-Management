You will need a Secret class like this to store authkey
  namespace Movie_Theater_Management
  {
      internal class Secret
      {
          public static string authKey { private set; get; } = YOUR_FIREBASE_AUTH_KEY;
      }
  }

