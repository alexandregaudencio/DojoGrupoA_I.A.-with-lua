    -- Defina um nome com até 6 caracteres (sem acentos e cedilha)
    name = "Pablo"
    CharacterBehaviour = nil;

    id = 2
    
     function Update() 
         -- verificando o número de almas/pontos acompanhando o jogador
         if Souls() >= 1 then
            ReturnToBase()
        end  
    
        if Souls() >= 1 then
            ReturnToBase()
        end
    
        -- if Souls() == 0 then 
        --     Attack ()
        -- end  
    
        if Souls() == 0 then 
            SetNearPlayerDestination()
            Attack ()
        end
        -- verificando se o personagem está próximo do alvo previamente definido
        if IsNear() == true then
            Attack ()
        end
    
        if Souls() >= 1 then

                SetNearPlayerDestination()
                Attack ()
            
        end
    end

    
function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance + 2)

end

function Souls() 

   return CharacterBehaviour.playerScript.Souls;

end