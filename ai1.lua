-- Defina um nomr com até 6 caracteres (sem acentos ou cedilha)
name = "ALE"
CharacterBehaviour = nil;

 function Update() 
    
    if Souls() == 0 then
        CharacterBehaviour.playerAgent.speed = 3.2;
        SetNearPlayerDestination()


    end


    if Souls() > 0 then
        ReturnToBase()
        CharacterBehaviour.playerAgent.speed = 4.5;


    end
    
    Attack()
    -- if IsNear() == true then
    --     Attack()
    -- end  
    









end


function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance+2)

end

 function Souls() 

    return CharacterBehaviour.playerScript.Souls;

 end

