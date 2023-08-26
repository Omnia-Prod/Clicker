using Mono.Collections.Generic;
using UnityEngine;

public class UpgradeManager
{
    public UpgradeManager()
    {
        this.AutoClickUpgrade = new AutoClickUpgrade();
        this.MultiClickUpgrade = new MultiClickUpgrade();
        Upgrades = new Collection<Upgrade>()
        {
            this.AutoClickUpgrade,
            this.MultiClickUpgrade
        };
    }

    public AutoClickUpgrade AutoClickUpgrade { get; set; } 
    public MultiClickUpgrade MultiClickUpgrade { get; set; } 

    public Collection<Upgrade> Upgrades { get; set; } 
    
    private float _timePassed = 0f;

    public void Update()
    {
        _timePassed += Time.deltaTime;
        if (!(_timePassed > 1f)) return;

        foreach (var up in Upgrades)
        {
            if (this.AutoClickUpgrade.IsBought)
                return;
        }
        
        _timePassed = 0f;
    }
}