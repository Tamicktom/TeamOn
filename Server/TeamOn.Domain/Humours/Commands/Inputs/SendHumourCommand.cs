using Flunt.Notifications;
using Flunt.Validations;
using TeamOn.Domain.Contracts.Commands;
using TeamOn.Domain.Humours.Enums;

namespace TeamOn.Domain.Humours.Commands.Inputs
{
    public class SendHumourCommand : ICommandContract
    {
        public SendHumourCommand(EHumourStatus humourStatus,
                                string refUser,
                                string message)
        {
            HumourStatus = humourStatus;
            RefUser = refUser;
            Message = message;
        }

        public EHumourStatus HumourStatus { get; private set; }
        public string RefUser { get; private set; }
        public string Message { get; private set; }

        public override bool Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNullOrEmpty(RefUser, "RefUser", "Informe um usuário.")
            );

            return true;
        }
    }
}