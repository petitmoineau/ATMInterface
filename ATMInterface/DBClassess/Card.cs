﻿namespace ATMInterface.DBClassess
{
    public class Card
    {
        public string Id_number { get; set; }
        public string Pasword { get; set; }
        public int Balance { get; set; }
        public string Card_type { get; set; }
        public string Currency { get; set; }
        public string Start_date { get; set; }
        public string Expiry_date { get; set; }
        public int Id_user { get; set; }
        public int Id_bank { get; set; }
    }
}
