﻿namespace VkNet.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Исключение, которое выбрасывается в случае, если параметр принимал недействительное значение.
    /// </summary>
    [DataContract]
    public class InvalidParameterException : VkApiMethodInvokeException
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса InvalidParameterException
        /// </summary>
        public InvalidParameterException()
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса InvalidParameterException
        /// </summary>
        /// <param name="message">Описание исключения.</param>
        public InvalidParameterException(string message) : base(message)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса InvalidParameterException
        /// </summary>
        /// <param name="message">Описание исключения.</param>
        /// <param name="innerException">Внутреннее исключение.</param>
        public InvalidParameterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса InvalidParameterException
        /// </summary>
        /// <param name="message">Описание исключения.</param>
        /// <param name="code">Код ошибки, полученный от сервера ВКонтакте.</param>
        public InvalidParameterException(string message, int code) : base(message, code)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса InvalidParameterException
        /// </summary>
        /// <param name="message">Описание исключения.</param>
        /// <param name="code">Код ошибки, полученный от сервера ВКонтакте.</param>
        /// <param name="innerException">Внутреннее исключение.</param>
        public InvalidParameterException(string message, int code, Exception innerException) : base(message, code, innerException)
        {
        }
    }
}