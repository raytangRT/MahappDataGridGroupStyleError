﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahappDataGridNoValidationError
{
    public class ItemA
    {
        private string _key;

        public string Key
        {
            get { return _key; }
            set
            {
                this._key = value;
                /*
                if (true)
                {
                    Task.Run(() => {
                        if (true) throw new Exception("Exception when setting Key");
                    });
                }*/
            }
        }

        public string Value { get; set; }

    }
}
