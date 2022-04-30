using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraWalletRpc
{
    public interface INetworkInfo
    {
        public string Name { get; set; }
        public string MessagePrefix { get; set; }
        public string Bech32 { get; set; }
        public Bip32 Bip32 { get; set; }
        public long PubKeyHash { get; set; }
        public long ScriptHash { get; set; }
        public long Wif { get; set; }
    }

    public class Bip32
    {
        public long Public { get; set; }
        public long Private { get; set; }
    }
}
