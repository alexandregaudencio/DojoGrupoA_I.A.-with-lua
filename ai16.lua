name = "Pedrin"
CharacterBehaviour = nil;

id = 2

function Update() 
    if Souls() <= 1 then 
    SetNearPlayerDestination()
    if IsNear() == true then
    Attack()
end
end

if IsNear() == true then
    Attack()
    end

if Souls() >= 2 then
        ReturnToBase()
    end


end


function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance + 2)

end

function Souls() 

   return CharacterBehaviour.playerScript.Souls;

end
