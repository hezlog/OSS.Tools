﻿#region Copyright (C) 2016 Kevin (OSS开源系列) 公众号：osscoder

/***************************************************************************
*　　	文件功能描述：Http请求 == 请求实体
*
*　　	创建人： Kevin
*       创建人Email：1985088337@qq.com
*       
*****************************************************************************/

#endregion

using System;
using System.Collections.Generic;
using System.Net.Http;

namespace OSS.Http.Mos
{
    /// <summary>
    /// 请求实体
    /// </summary>
    public class OsHttpRequest
    {
       

        /// <summary>
        /// 请求地址信息
        /// </summary>
        public Uri Uri{ get; set; }

        /// <summary>
        ///  如果此值设置，则忽略 Uri 值
        /// </summary>
        public string AddressUrl { get; set; }

        /// <summary>
        /// 请求方式
        /// </summary>
        public HttpMethod HttpMethod { get; set; } = HttpMethod.Get;

        ///// <summary>
        /////  是否允许自动重定向
        ///// 默认为true  最大可重定向次数为 5
        ///// </summary>
        //public bool AllowAutoRedirect { get; set; } = true;

        ///// <summary>
        /////   是否使用压缩
        ///// </summary>
        //public bool AutoDecompres { get; set; }

        ///// <summary>
        /////   是否使用cookie 
        ///// </summary>
        //public bool UseCookies { get; set; } = false;

        ///// <summary>
        /////  是否使用代理
        ///// </summary>
        //public bool UseProxy { get; set; } = true;

        /// <summary>
        ///   reqMessage 设置方法
        ///    如果当前的设置不能满足需求，可以通过这里再次设置
        /// </summary>
        public Action<HttpRequestMessage> RequestSet { get; set; }

        #region   请求的内容参数

        /// <summary>
        /// 是否存在文件
        /// </summary>
        public bool HasFile => _fileParameters != null && _fileParameters.Count > 0;


        private List<FileParameter> _fileParameters;
        /// <summary>
        /// 文件参数列表
        /// </summary>
        public List<FileParameter> FileParameters => _fileParameters ?? (_fileParameters = new List<FileParameter>());// 兼容老版本，取值时默认赋值


        /// <summary>
        ///  添加文件
        /// </summary>
        /// <param name="file"></param>
        public void AddFile(FileParameter file)
        {
            FileParameters.Add(file);
        }
        
        private List<FormParameter> _formParameters;
        /// <summary>
        /// 非文件参数列表
        /// </summary>
        public List<FormParameter> FormParameters => _formParameters ?? (_formParameters = new List<FormParameter>());// 兼容老版本，取值时默认赋值


        /// <summary>
        ///  添加文件
        /// </summary>
        /// <param name="formPara"></param>
        public void Add(FormParameter formPara)
        {
            FormParameters.Add(formPara);
        }

        #endregion

        /// <summary>
        /// 自定义内容实体
        /// eg:当上传文件时，无法自定义内容
        /// </summary>
        public string CustomBody { get; set; }

        /// <summary>
        ///    超时时间（毫秒）
        /// </summary>
        public int TimeOutMilSeconds { get; set; }

    }
}
