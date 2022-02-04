using System;
using PingUI.Model;
using System.Net.NetworkInformation;

namespace PingUI.ViewModel
{
    public class MainViewModel
    {
        private PingResult pingResult;
        private string address;
        private Ping ping;

        public MainViewModel()
        {
            pingResult = new PingResult()
            {
                Address = "-",
                Status = "-",
                Time = "-"
            };

            ping = new Ping();

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
        public EventHandler HideResults { get; set; }
        public EventHandler ShowResults { get; set; }

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
                PingResult.Address = "-";
                PingResult.Status = IPStatus.Unknown.ToString();
                PingResult.Time = "-";
                return;
            }

            PingResult.Address = reply.Address.ToString();
            PingResult.Status = reply.Status.ToString();
            PingResult.Time = (reply.RoundtripTime + " ms").ToString();
        }
    }
}
