﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewLife.Xml;
using System.Xml.Serialization;

namespace NewLife.Core.Test.Xml
{
    [XmlConfigFile("config/user.config", 1000)]
    public class UserConfig : XmlConfig<UserConfig>
    {
        private String _Name;
        /// <summary>属性说明</summary>
        public String Name { get { return _Name; } set { _Name = value; } }

        private String _Password;
        /// <summary>属性说明</summary>
        public String Password { get { return _Password; } set { _Password = value; } }

        private Int32 _Num;
        /// <summary>属性说明</summary>
        public Int32 Num { get { return _Num; } set { _Num = value; } }

        private SerializableDictionary<String, Int32> _Dic;
        /// <summary>属性说明</summary>
        public SerializableDictionary<String, Int32> Dic { get { return _Dic; } set { _Dic = value; } }

        private SerializableDictionary<String, UserConfig> _Dic2;
        /// <summary>属性说明</summary>
        public SerializableDictionary<String, UserConfig> Dic2 { get { return _Dic2; } set { _Dic2 = value; } }
    }
}
