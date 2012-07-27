﻿using System;

namespace VkToolkit.Model
{
    public class Attachment
    {
        public Type Type { get; set; }
        internal Audio Audio;

        public object Instance
        {
            get
            {
                if (Type == typeof(Audio))
                return Audio;

                return null;
            }
        }
    }
}