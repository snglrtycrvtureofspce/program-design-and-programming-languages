using System;

namespace Lab09
{
    public struct Ats
    {
        public string _talk; // дата разговора
        public int _code; // код города
        public string _city; // название города
        public int _timetalk; // время разговора в минутах (округлено)
        public double _rate; // тариф
        public string _citynum; // номер телефона в этом городе
        public string _citysub; // номер телефона абонента
        public Ats() {}
        public Ats(string talk, int code, string city, int timetalk, double rate, string citynum, string citysub)
        {
            _talk = talk;
            _code = code;
            _city = city;
            _timetalk = timetalk;
            _rate = rate;
            _citynum = citynum;
            _citysub = citysub;
        }

        public override string ToString()
        {
            return $"Дата раговора: {this._talk}\nКод города: {this._code}\nНазвание города: {this._city}" +
                   $"\nВремя разговора в минутах (округлено): {this._timetalk}\nТариф: {this._rate}" +
                   $"\nНомер телефона в этом городе: {this._citynum}\nНомер телефона абонента: {this._citysub}" +
                   $"\nОбщее время разговора/сумма: {this._timetalk}/{this._timetalk*this._rate}руб";
        }
    }

}