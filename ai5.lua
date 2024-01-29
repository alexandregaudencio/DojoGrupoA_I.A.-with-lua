-- Defina um nome com até 6 caracteres (sem acentos e cedilha)
name = "Michel"

-- clase c# que contém o Script do player (playerScript) e um NavMesAgent (playerAgent)
CharacterBehaviour = nil;

id = 2

function Update() 
    SetNearPlayerDestination()
   Attack()




    if Souls() >= 2 then
        ReturnToBase()
    end

end


 function Souls() 
    return CharacterBehaviour.playerScript.Souls;
 end



