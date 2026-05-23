using System.Collections.Generic;

namespace OLegadoMaisModerno.WinForms.Models
{
    public class DeepSeekResponse
    {
        public List<DeepSeekChoice> choices { get; set; }
    }

    public class DeepSeekChoice
    {
        public DeepSeekMessage message { get; set; }
    }

    public class DeepSeekMessage
    {
        public string role { get; set; }
        public string content { get; set; }
    }
}