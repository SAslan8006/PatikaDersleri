import React, { useState } from 'react'
import { View, Text, ScrollView } from 'react-native'
import RaporsHeader from '../../components/RaporsCard/RaporsHeader';
import Calories from './Calories/Calories';
import Makro from './Makro';
import styles from "./Rapors.style"


const Rapors = () => {
    const menus = [
        { name: "KALORILER" },
        { name: "MAKROLAR" }
    ]
    const [active, setActive] = useState("KALORILER")
    const handleMenuClick = (name) => {
        setActive(name)
    }
    console.log(active)
    return (
        <>
            <Text style={styles.header}>Raporlar</Text>

            <View style={styles.menu_container}>
                {
                    menus.map(({ name }) => (
                        <RaporsHeader name={name} key={name} active={active} handleMenuClick={handleMenuClick} />
                    ))
                }
            </View>

            <ScrollView>
                {
                    active === "KALORILER" ? <Calories />
                        : <Makro />

                }
            </ScrollView>
        </>
    )
}

export default Rapors
