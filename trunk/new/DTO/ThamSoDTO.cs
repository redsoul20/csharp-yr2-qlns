namespace DTO
{
    class ThamSoDTO
    {
        private int _soLuongNhapNN;
        private int _luongTonLN;
        private int _luongTonNN;
        private decimal _noLN;

        public int SoLuongNhapNN
        {
            get { return _soLuongNhapNN; }
            set { _soLuongNhapNN = value; }
        }

        public int LuongTonLN
        {
            get { return _luongTonLN; }
            set { _luongTonNN = value; }
        }

        public int LuongTonNN
        {
            get { return _luongTonNN; }
            set { _luongTonNN = value; }
        }

        public decimal NoLN
        {
            get { return _noLN; }
            set { _noLN = value; }
        }
    }
}
