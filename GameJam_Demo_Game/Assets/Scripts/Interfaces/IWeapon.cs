
/// <summary>
/// This allows all weapons to be able to put in a single collection
/// </summary>
interface IWeapon
{
    /// <summary>
    /// The damage of the weapon
    /// </summary>
    int Damage { get; set; }

    /// <summary>
    /// The ammo of the weapon
    /// </summary>
    int Ammo { get; set; }

    /// <summary>
    /// Attack of the weapon goes off
    /// </summary>
    void Attack();
}
