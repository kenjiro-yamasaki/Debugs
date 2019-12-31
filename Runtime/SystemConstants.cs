﻿using System.IO;
using System.Reflection;

namespace SoftCube.Debug
{
    /// <summary>
    /// システム定数。
    /// </summary>
    public static class SystemConstants
    {
        #region プロパティ

        /// <summary>
        /// 実行ファイルパス。
        /// </summary>
        public static string ExecutableAssemblyPath => Assembly.GetExecutingAssembly().Location;

        /// <summary>
        /// 実行ファイルのディレクトリパス。
        /// </summary>
        public static string ExecutableDirectoryPath => Path.GetDirectoryName(ExecutableAssemblyPath);

        #endregion
    }
}
