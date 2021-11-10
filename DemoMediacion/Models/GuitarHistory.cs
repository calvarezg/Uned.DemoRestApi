using System;

namespace DemoMediacion.Models
{
    public class GuitarHistory
    {
        public ActionType Action { get; set; }

        public DateTime Date { get; }

        public GuitarHistory(ActionType action)
        {
            Action = action;
            Date = DateTime.Now;
        }
    }
}
