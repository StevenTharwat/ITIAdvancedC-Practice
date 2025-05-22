namespace D2
{
    internal class SingleTon
    {
        string Ip = "";
        SingleTon(string ip)
        {
            Ip = ip;
        }
        static SingleTon singleTon;
        public static SingleTon GetObj(string ip)
        {
            if (singleTon == null)
            {
                singleTon = new SingleTon(ip);
            }
            return singleTon;
        }

        public string GetIp()
        {
            return Ip;
        }
    }
}
