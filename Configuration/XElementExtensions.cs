﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SoftCube.Configuration
{
    /// <summary>
    /// <see cref="XElement"/> の拡張メソッド。
    /// </summary>
    public static class XElementExtensions
    {
        #region メソッド

        /// <summary>
        /// プロパティ値を取得します。
        /// </summary>
        /// <param name="xelement">XML の要素。</param>
        /// <param name="name">プロパティ名。</param>
        /// <returns>プロパティ値。</returns>
        public static string Property(this XElement xelement, string name)
        {
            return (string)xelement.Elements("param").Single(e => (string)e.Attribute("name") == name).Attribute("value");
        }

        /// <summary>
        /// プロパティ値コレクションを取得します。
        /// </summary>
        /// <param name="xelement">XML の要素。</param>
        /// <param name="name">プロパティ名。</param>
        /// <returns>プロパティ値コレクション。</returns>
        public static IEnumerable<string> Properties(this XElement xelement, string name)
        {
            return xelement.Elements("param").Where(e => (string)e.Attribute("name") == name).Select(e => (string)e.Attribute("value"));
        }

        #endregion
    }
}
