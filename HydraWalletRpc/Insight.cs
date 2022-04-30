using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraWalletRpc
{
    public class Insight
    {
        const string MAINNET = "hydra";
        const string TESTNET = "hydra_testnet";
        public readonly static Dictionary<string, string> INSIGHT_BASEURLS = new Dictionary<string, string>()
        {
            [MAINNET] = "https://explorer.hydrachain.org/api",
            [TESTNET] = "https://testexplorer.hydrachain.org/api"
        };

    }
}
