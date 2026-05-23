using System.Collections.Generic;

namespace OLegadoMaisModerno.WinForms.Models
{
    public class DeepSeekRequest
    {
        public string model { get; set; }
        public List<ChatMessage> messages { get; set; }
        public bool stream { get; set; }

        public DeepSeekRequest()
        {
            model = "deepseek-chat";
            messages = new List<ChatMessage>();
            stream = false;
        }
    }
}