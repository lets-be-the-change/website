using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LbtcWebsite.Secrets
{
    public class PaymentGatewaySecrets
    {
        public static string CLIENT_ID { get { return "N8SHLaqlyL07o2ysCCl1OjrILlMKDTdn8lSfh3Ki"; } }
        public static string CLIENT_SECRET { get { return "BJav9JcMUB6E54wGzHrCs3GZimttoIaGvj4ugbaYDTWm7vRKeGEoUOJtbOh7nfK33WMWijHL0RpDNgMQMg0h6lfrMNq9NECT6lchRy5IFXrZh59rRbvjL7v8j8cMMnys"; } }
        public static string API_ENDPOINT { get { return "https://api.instamojo.com/v2/"; } }
        public static string AUTH_ENDPOINT { get { return "https://www.instamojo.com/oauth2/token/"; } }
    }
}