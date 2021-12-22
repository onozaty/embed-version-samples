package com.github.onozaty.embed;

public class Main {

    public static void main(String[] args) {

        String implementationVersion = getImplementationVersion();
        System.out.println("implementationVersion: " + implementationVersion);
    }

    private static String getImplementationVersion() {
        return Main.class.getPackage().getImplementationVersion();
    }

}
