    -- Defina um nome com até 6 caracteres (sem acentos e cedilha)
    name = "Maria"
    id =2
    -- clase c# que contém o Script do player (playerScript) e um NavMesAgent (playerAgent)
    CharacterBehaviour = nil;
    
    
     function Update() 
         -- verificando o número de almas/pontos acompanhando o jogador
        if Souls() >= 1 then
            ReturnToBase()
        end  
    
    
        if Souls() == 0 and SetNearPlayerDestination () == 1 then 
            Attack ()
        end  
    
        -- verificando se o personagem está próximo do alvo previamente definido
        if IsNear() == true then
            Attack ()
        end
    

    end
    
    -- VERIFICA SE ESTA PRÓXIMO DO ALVO PREVIAMENTE DEFINIDO. O NÚMERO 2 AJUSTA A DISTANCIA. 
    function IsNear() 
        return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance+2)
    
    end
    
    -- número de almas/pontos acompanhando o jogador
     function Souls() 
        return CharacterBehaviour.playerScript.Souls;
     end
    