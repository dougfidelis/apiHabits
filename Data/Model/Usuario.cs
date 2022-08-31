using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Usuario : BaseModel
    {
        public string Email { get; set; }
        [JsonIgnore]
        public string Senha { get; set; }
        public string Nome { get; set; }

    }
}
