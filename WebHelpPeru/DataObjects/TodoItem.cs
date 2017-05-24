using Microsoft.Azure.Mobile.Server;

namespace WebHelpPeru.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}