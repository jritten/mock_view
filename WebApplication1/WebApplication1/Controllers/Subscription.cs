using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Controllers
{
    internal class Subscription
    {
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public bool Triggered { get; set; }
        public string AlertCondition { get; set; }
        public string SubscriptionStart { get; set; }
        public string SubscriptionEnd { get; set; }

    }
}