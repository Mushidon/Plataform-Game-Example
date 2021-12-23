namespace Donic.Scripts.Interfaces
{
    /// <summary>
    /// Interface responsável por definir as movimentações básicas do player.
    /// Cada uma dessas deve virar um comando concreto. 
    /// </summary>
    public interface IPlayerMovement 
    {
        void MoveUp();

        void MoveDown();

        void MoveLeft();

        void MoveRight();
    }

}