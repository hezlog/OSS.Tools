#region Copyright (C) 2016 Kevin (OSS��Դϵ��) ���ںţ�OSSCore

/***************************************************************************
*����	�ļ�����������ȫ�ֲ�� -  �������ӿ�
*
*����	�����ˣ� Kevin
*       ������Email��1985088337@qq.com
*       
*       
*****************************************************************************/

#endregion

using System;

namespace OSS.Tools.Cache
{
    /// <summary>
    /// �������ӿ�
    /// </summary>
    public interface ICachePlug
    {
        /// <summary>
        /// ���ӻ���,������������
        /// </summary>
        /// <typeparam name="T">���ӻ����������</typeparam>
        /// <param name="key">���Ӷ����key</param>
        /// <param name="obj">ֵ</param>
        /// <param name="slidingExpiration">��Թ��ڵ�TimeSpan  ���ʹ�ù̶�ʱ��  =TimeSpan.Zero</param>
        /// <param name="absoluteExpiration"> ���Թ���ʱ��,��Ϊ�����վ��Թ���ʱ����� </param>
        /// <returns>�Ƿ����ӳɹ�</returns>
        [Obsolete]
        bool AddOrUpdate<T>(string key, T obj, TimeSpan slidingExpiration, DateTime? absoluteExpiration = null);

        /// <summary> 
        /// ����ʱ��ι��ڻ���
        /// ������������
        /// </summary>
        /// <typeparam name="T">���ӻ����������</typeparam>
        /// <param name="key">���Ӷ����key</param>
        /// <param name="obj">ֵ</param>
        /// <param name="slidingExpiration">��Թ��ڵ�TimeSpan</param>
        /// <returns>�Ƿ����ӳɹ�</returns>
        bool Set<T>(string key, T obj, TimeSpan slidingExpiration);

        /// <summary>
        /// ���ӹ̶�����ʱ�仺��,������������
        /// </summary>
        /// <typeparam name="T">���ӻ����������</typeparam>
        /// <param name="key">���Ӷ����key</param>
        /// <param name="obj">ֵ</param>
        /// <param name="absoluteExpiration"> ���Թ���ʱ��,��Ϊ�����վ��Թ���ʱ����� </param>
        /// <returns>�Ƿ����ӳɹ�</returns>
        bool Set<T>(string key, T obj, DateTime absoluteExpiration);

        /// <summary>
        /// ��ȡ�������
        /// </summary>
        /// <typeparam name="T">��ȡ�����������</typeparam>
        /// <param name="key">key</param>
        /// <returns>��ȡָ��key��Ӧ��ֵ </returns>
        T Get<T>(string key);


        //Task<RType> Get<RType>(string cacheKey, Func<Task<RType>> createFunc, DateTime absoluteExpiration);

        //Task<RType> Get<RType>(string cacheKey, Func<Task<RType>> createFunc, TimeSpan slidingExpiration);

        /// <summary>
        /// �Ƴ��������
        /// </summary>
        /// <param name="key"></param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Remove(string key);

    }
}