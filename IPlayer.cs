using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    interface IPlayer
    {
        int GetScore();
        void GainPoint();
        bool Alive();
        void Kill();
        bool TopScore();
    }
}
