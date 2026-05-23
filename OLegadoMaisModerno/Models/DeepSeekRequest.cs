using System.Collections.Generic;

namespace OLegadoMaisModerno.WinForms.Models
{
    public class DeepSeekRequest
    {
        public string model { get; set; } = "deepseek-chat";
        public List<ChatMessage> messages { get; set; } = new();
        public bool stream { get; set; } = false;
    }
}