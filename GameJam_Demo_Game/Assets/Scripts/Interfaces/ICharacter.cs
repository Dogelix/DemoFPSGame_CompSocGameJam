/// <summary>
/// The base for both enemies and the player(s)
/// </summary>
interface ICharacter : IDamagable
{
    /// <summary>
    /// The weapon inventory of the character
    /// </summary>
    IWeapon[] Weapons { get; set; }

    /// <summary>
    /// Character does something everytime this method is called
    /// e.g. increment the player's health by 5
    /// </summary>
    void Tick();

    /// <summary>
    /// Call when the character attacks
    /// </summary>
    void Attack();
}
