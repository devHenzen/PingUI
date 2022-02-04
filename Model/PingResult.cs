using System.Net.NetworkInformation;
using System.Net;

namespace PingUI.Model
{
    public class PingResult : BaseModel
    {
        private string address;
        private string status;
        private string time;

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (this.address != value)
                {
                    this.address = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                if(this.status != value)
                {
                    this.status = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if(this.time != value)
                {
                    this.time = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
