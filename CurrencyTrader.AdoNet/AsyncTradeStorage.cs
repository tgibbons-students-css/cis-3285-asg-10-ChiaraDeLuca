using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader.AdoNet
{
	class AsyncTradeStorage : ITradeStorage
	{
        private readonly Ilogger logger;
        private ITradeStorage SynchTradeStorage;

        public AsyncTradeStorage(ILogger loggere)
        {
            this.logger = logger;
            SynchTradeStorage = new AdoNetTradeStorage(logger);
        }
        public void Persist(IEnumerable<TradeRecord> trades)
        {
            logger.LogInfo("Connecting to Database");
            SynchTradeStorage.Persist(trades);

        }
	}
}
