using System.Collections.Generic;
using System.Threading.Channels;
using System.Threading.Tasks;
using WEbCam_Streaiming_framework.Hubs.ModelsHub;

namespace WEbCam_Streaiming_framework.Hubs
{
    public interface IConnectionHub
    {
        Task AttUsuariosOnline(List<User> userList);
        Task LigaCaoAceita(User acceptingUser);
        Task LidacaoNegada(User decliningUser, string reason);
        Task EmLigacao(User callingUser);
        Task ReceiveData(User signalingUser, string signal);
        Task UploadStream(ChannelReader<string> stream);
        Task LigacaoDesligada(User signalingUser, string signal);
    }
}
