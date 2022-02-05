using System.Net.NetworkInformation;
using System.Net;

namespace PingUI.Model
{
    public class PingResult : BaseModel
    {
        private string address;
        private string status;
        private string time;

        /// <summary>
        /// Responding ipv4 / ipv6 address 
        /// usually type IPAddress
        /// string, in order to have more control on how data gets displayed
        /// </summary>
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

        /// <summary>
        /// Status of the ping
        /// usually type IPStatus
        /// string, in order to have more control on how data gets displayed
        /// </summary>
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

        /// <summary>
        /// Time needed to complete the ping process
        /// usually type long
        /// string, in order to have more control on how data gets displayed
        /// </summary>
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
