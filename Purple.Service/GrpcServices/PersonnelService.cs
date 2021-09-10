using Grpc.Core;
using Purple.Service.Grpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purple.Service
{
    public class PersonnelService : PersonnelGrpcService.PersonnelGrpcServiceBase
    {
        public override async Task<PersonnelResponse> SavePersonnel(PersonnelRequest request, ServerCallContext context)
        {
            await Task.Delay(500);
            PersonnelResponse response = new();
            response.Result = true;
            return response;
        }
    }
}
