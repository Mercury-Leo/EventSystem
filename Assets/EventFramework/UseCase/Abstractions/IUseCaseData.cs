namespace EventFramework.UseCase.Abstractions {
    public interface IUseCaseData {
        object Data { get; }
        IEventUseCase UseCase { get; }
    }
}