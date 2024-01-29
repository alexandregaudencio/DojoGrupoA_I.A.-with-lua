-- Defina um nome com até 6 caracteres (sem acentos e cedilha)
name = "Wagner"

-- clase c# que contém o Script do player (playerScript) e um NavMesAgent (playerAgent)
CharacterBehaviour = nil;

id = 2

function Update() 
    if IsNear() == true then
	Attack()
    end
   

    SetNearPlayerDestination()

    if Souls() >= 3 then
        ReturnToBase()
    end
end


 function Souls() 
    return CharacterBehaviour.playerScript.Souls;
 end

function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance <= CharacterBehaviour.playerAgent.stoppingDistance+1)

end

