using System;
using PingUI.Model;
using System.Net.NetworkInformation;

namespace PingUI.ViewModel
{
    public class MainViewModel
    {
        private const string DEFAULT_RESULT_DATA = "-";

        private PingResult pingResult;
        private string address;
        private Ping ping;

        public MainViewModel()
        {
            pingResult = new PingResult()
            {
                Address = DEFAULT_RESULT_DATA,
                Status = DEFAULT_RESULT_DATA,
                Time = DEFAULT_RESULT_DATA
            };

            ping = new Ping();
            address = string.Empty;

            CloseApp = new DelegateCommand((o) => this.CloseApplication());
            Ping = new DelegateCommand((o) => this.PingAddress());
        }

        public PingResult PingResult
        {
            get
            {
                return this.pingResult;
            }
            set
            {
                if (this.pingResult != value)
                {
                    this.pingResult = value;
                }
            }
        }

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
                }
            }
        }

        public DelegateCommand CloseApp { get; set; }
        public DelegateCommand Ping { get; set; }

        private void CloseApplication()
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void PingAddress()
        {
            PingReply reply;
            try
            {
                reply = ping.Send(this.address);
            }
            catch (Exception ex)
            {
                PingResult.Address = DEFAULT_RESULT_DATA;
                PingResult.Status = IPStatus.Unknown.ToString();
                PingResult.Time = DEFAULT_RESULT_DATA;
                return;
            }

            PingResult.Address = reply.Address.ToString();
            PingResult.Status = reply.Status.ToString();
            PingResult.Time = (reply.RoundtripTime + " ms").ToString();
        }
    }
}
