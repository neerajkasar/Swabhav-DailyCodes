using System;

namespace AdditionLibrary
{
    public class AddClass
    {
        private int _fno, _sno, _ans;
       
        AddClass(int fno, int sno)
        {
            _fno = fno;
            _sno = sno;

        }
        public int Answer
        {
            get
            {
                return _ans = _fno + _sno;
            }
        }
    }
}
