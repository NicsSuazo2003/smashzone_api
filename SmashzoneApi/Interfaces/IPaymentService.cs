using SmashzoneApi.DTOs;

namespace SmashzoneApi.Interfaces;

public interface IPaymentService
{
    Task<PaymentResponse> ProcessAsync(ProcessPaymentRequest request);
}