using Grpc.Net.Client;
using Purple.Service.Grpc;
using System;
using System.Threading.Tasks;

namespace Purple.Wpf.BL
{
    public class PersonnelClient
    {
        PersonnelGrpcService.PersonnelGrpcServiceClient _client;

        public PersonnelClient()
        {
            _client = new(GrpcChannel.ForAddress("http://localhost:44342"));
        }

        public async Task<PersonnelResponse> SavePersonnel(PersonnelRequest request)
        {
            return await _client.SavePersonnelAsync(request);
        }
    }
}
