using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Helpers
{
    public abstract class EntityHelpers
    {
        public string GenerateUniqueId()
        {
            byte[] bytes = new byte[24]; // 24 byte - 192bit
            new Random().NextBytes(bytes) ; // Random bits
            return Convert.ToBase64String(bytes);
        }
    }
}
