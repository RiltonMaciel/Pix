﻿namespace Pay.Recorrencia.Gestao.Domain.Services
{
    public interface IKafkaProducerService
    {
        Task SendMessageAsync(string topic, string message);
    }
}
