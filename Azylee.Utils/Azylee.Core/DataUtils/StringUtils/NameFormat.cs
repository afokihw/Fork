﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azylee.Core.DataUtils.StringUtils
{
    public class NameFormat
    {
        public static string ToCamelCase(string s)
        {
            string result = "";
            if (Str.Ok(s))
            {
                if (s.IndexOf('_') >= 0)
                {
                    bool upFlag = false;
                    char[] cArray = s.ToArray();
                    foreach (var c in cArray)
                    {
                        if (c == '_')
                        {
                            upFlag = true;
                            continue;
                        }

                        if (upFlag)
                        {
                            result += c.ToString().ToUpper();
                            upFlag = false;
                        }
                        else
                        {
                            result += c.ToString().ToLower();
                        }
                    }
                }
                else
                {
                    result = s;
                }
            }
            return result;
        }
        public static string ToUpCamelCase(string s)
        {
            string result = "";
            if (Str.Ok(s))
            {
                bool upFlag = false;
                char[] cArray = s.ToArray();
                for (int i = 0; i < cArray.Length; i++)
                {
                    char c = cArray[i];
                    if (c == '_')
                    {
                        upFlag = true;
                        continue;
                    }

                    if (upFlag || i == 0)
                    {
                        result += c.ToString().ToUpper();
                        upFlag = false;
                    }
                    else
                    {
                        result += c.ToString().ToLower();
                    }
                }
            }
            return result;
        }
        public static string ToUnderline(string s)
        {
            string result = "";
            if (Str.Ok(s))
            {
                char[] cArray = s.ToArray();
                foreach (var c in cArray)
                {
                    char cUpper = char.ToUpper(c);
                    char cLower = char.ToLower(c);
                    if (c >= 'A' && c <= 'Z')
                    {
                        result += "_";
                    }
                    result += char.ToLower(c);
                }
            }
            return result;
        }
    }
}
