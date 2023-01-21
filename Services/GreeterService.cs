using Easy.Logger.Interfaces;
using Grpc.Core;

namespace grpc_asynclogger4net.Services
{
	public class GreeterService : Greeter.GreeterBase
	{
		private readonly ILogger<GreeterService> MSLogger;
		private readonly IEasyLogger<GreeterService> EasyLogger;

		public GreeterService(ILogger<GreeterService> logger, IEasyLogger<GreeterService> easyLogger)
		{
			MSLogger = logger;
			EasyLogger = easyLogger;
		}

		public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
		{
			EasyLogger.Info("im at SayHello");

			return Task.FromResult(new HelloReply
			{
				Message = "Hello " + request.Name
			});
		}
	}
}