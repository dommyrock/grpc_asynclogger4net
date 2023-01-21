using Easy.Logger.Interfaces;

namespace grpc_asynclogger4net.Services
{
	public class BenchmarkingService
	{
		private readonly IEasyLogger<GreeterService> EasyLogger;

		public BenchmarkingService(IEasyLogger<GreeterService> easyLogger)
		{
			EasyLogger = easyLogger;
		}
	}
}