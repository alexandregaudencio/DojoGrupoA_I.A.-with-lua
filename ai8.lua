-- Defina um nome com até 6 caracteres (sem acentos e cedilha)
name = "JM"

-- clase c# que contém o Script do player (playerScript) e um NavMesAgent (playerAgent)
CharacterBehaviour = nil;

id = 3

function Update() 

	Attack()


    if IsFar() == true then
	SetNearPlayerDestination()
    end

    if IsNear() == true then
	SetNearPlayerDestination()
    end

    if Souls() >= 2 then
        ReturnToBase()
    end
end

function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance <= CharacterBehaviour.playerAgent.stoppingDistance+1)

end

function IsFar() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance+50)

end

 function Souls() 
    return CharacterBehaviour.playerScript.Souls;
 end
